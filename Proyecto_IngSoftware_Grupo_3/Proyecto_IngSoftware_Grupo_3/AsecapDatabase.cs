using Npgsql;
using System.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Proyecto_IngSoftware_Grupo_3

{
    internal class AsecapDatabase
   
    {
        //private NpgsqlConnection connection;
        private const string CONNECTION_STRING = "Host=localhost:5432;"+"Username=postgres;"+"Password=0609;"+"Database=ASECAPDatabase";
        private const string TABLA_ADMIN = "adm";
        private const string TABLA_CLIENTE = "cliente";
        private const string TABLA_DOCUMENTO = "documento";

        internal NpgsqlConnection Connect()
        {
            NpgsqlConnection connection = new NpgsqlConnection(CONNECTION_STRING);
            connection.Open();
            return connection;
        }

        internal void AddAdmin(Admin adm)
        {
            NpgsqlConnection connection = Connect();
            string commandText = $"insert into {TABLA_ADMIN} (rut_admin, pass) values (@rut_admin, @pass)";
            using (var cmd = new NpgsqlCommand(commandText, connection))
            {
                cmd.Parameters.AddWithValue("rut_admin", adm.rut_admin);
                cmd.Parameters.AddWithValue("pass", adm.pass);

                cmd.ExecuteNonQuery();
            }
            // falta tirar la excepcion si se agrega una llave foranea que no este en la base de datos
        }

        internal void AddCliente(Cliente cliente)
        {
            NpgsqlConnection connection = Connect();
            string commandText = $"insert into {TABLA_CLIENTE} (rut_cliente, rut_admin, tipo, nombre, descripcion) values (@rut_cliente, @rut_admin, @tipo, @nombre, @descripcion)";
            using (var cmd = new NpgsqlCommand(commandText, connection))
            {
                cmd.Parameters.AddWithValue("rut_admin", cliente.rut_admin);
                cmd.Parameters.AddWithValue("rut_cliente", cliente.rut_cliente);
                cmd.Parameters.AddWithValue("tipo", cliente.tipo);
                cmd.Parameters.AddWithValue("nombre", cliente.nombre);
                cmd.Parameters.AddWithValue("descripcion", cliente.descripcion);

                cmd.ExecuteNonQuery();
            }
            // falta tirar la excepcion si se agrega una llave foranea que no este en la base de datos
        }

        internal void AddDocumento(Documento documento)
        {
            NpgsqlConnection connection = Connect();
            string commandText = $"insert into {TABLA_DOCUMENTO} (id_documento, rut_cliente, tipo, fecha_modificacion) values (@id_documento, @rut_cliente, @tipo, @fecha_modificacion)";
            using (var cmd = new NpgsqlCommand(commandText, connection))
            {
                cmd.Parameters.AddWithValue("id_documento", documento.id_documento);
                cmd.Parameters.AddWithValue("rut_cliente", documento.rut_cliente);
                cmd.Parameters.AddWithValue("tipo", documento.tipo);
                cmd.Parameters.AddWithValue("fecha_modificacion", documento.fecha_modificacion);

                cmd.ExecuteNonQuery();
            }
            // falta tirar la excepcion si se agrega una llave foranea que no este en la base de datos
        }

        internal Admin GetAdminByUser(string user)
        {
            NpgsqlConnection connection = Connect();
            
            string commandText = $"SELECT * FROM {TABLA_ADMIN} WHERE rut_admin ='" + user + "'";
            NpgsqlCommand cmd = new NpgsqlCommand(commandText, connection);
            
            cmd.Parameters.AddWithValue("rut_admin", user);

            NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Admin adm = ReadAdmin(reader);
                return adm;
            }
            
            return null;
        }

        internal static Admin ReadAdmin(NpgsqlDataReader reader)
        {
            string? rut_admin = reader["rut_admin"] as string;
            string? pass = reader["pass"] as string;

            Admin adm = new Admin
            {
                rut_admin = rut_admin,
                pass = pass
            };

            return adm;
        }

        internal static Cliente ReadCliente(NpgsqlDataReader reader)
        {
            string? rut_cliente = reader["rut_cliente"] as string;
            string? rut_admin = reader["rut_admin"] as string;
            string? tipo = reader["tipo"] as string;
            string? nombre = reader["nombre"] as string;
            string? descripcion = reader["descripcion"] as string;

            Cliente cliente = new Cliente
            {
                rut_cliente = rut_cliente,
                rut_admin = rut_admin,
                tipo = tipo,
                nombre = nombre,
                descripcion = descripcion
            };

            return cliente;
        }

        internal Cliente GetClientByName(string name)
        {
            NpgsqlConnection connection = Connect();

            string commandText = $"SELECT * FROM {TABLA_CLIENTE} WHERE nombre ='" + name + "'";
            NpgsqlCommand cmd = new NpgsqlCommand(commandText, connection);

            cmd.Parameters.AddWithValue("nombre", name);

            NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Cliente cliente = ReadCliente(reader);
                return cliente;
            }

            return null;
        }

        internal Cliente GetClientByRut(string rut)
        {
            NpgsqlConnection connection = Connect();

            string commandText = $"SELECT * FROM {TABLA_CLIENTE} WHERE rut_cliente ='" + rut + "'";
            NpgsqlCommand cmd = new NpgsqlCommand(commandText, connection);

            cmd.Parameters.AddWithValue("rut_cliente", rut);

            NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Cliente client = ReadCliente(reader);
                return client;
            }

            return null;
        }

        internal static Documento ReadDocumento(NpgsqlDataReader reader)
        {
            string? id_documento = reader["id_documento"] as string;
            string? rut_cliente = reader["rut_cliente"] as string;
            string? tipo = reader["tipo"] as string;
            string? fecha_modificacion = reader["fecha_modificacion"] as string;

            Documento documento = new Documento
            {
                id_documento = id_documento,
                rut_cliente = rut_cliente,
                tipo = tipo,
                fecha_modificacion = fecha_modificacion
            };

            return documento;
        }

        internal DataTable ShowClientesDatabase()
        {
            NpgsqlConnection connection = Connect();

            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select * from {TABLA_CLIENTE}";

            NpgsqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                DataGridView dgv = new DataGridView();
                dgv.DataSource = dt;
                return dt;
            }
            return null;

        }

        internal string GetVersion()
        {
            NpgsqlConnection connection = Connect();
            var sql = "SELECT version()";

            using var cmd = new NpgsqlCommand(sql, connection);

            var versionFromQuery = (cmd.ExecuteScalar()).ToString();

            return versionFromQuery;
        }
    }
}