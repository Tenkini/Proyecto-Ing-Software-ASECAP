using Npgsql;
using System.Data;

namespace Proyecto_IngSoftware_Grupo_3

{
    internal class AsecapDatabase
   
    {
        private NpgsqlConnection connection;
        private const string CONNECTION_STRING = "Server = localhost; Port = 5432; User Id = postgres; Password = 0609; Database = ASECAPDatabase;";

        internal void Connect()
        {
            connection = new NpgsqlConnection(CONNECTION_STRING);
            connection.Open();
        }

        internal async Task AddAdmin(Admin adm)
        {
            string commandText = $"insert into {adm} (rut_admin, pass) values (@rut_admin, @pass)";
            await using (var cmd = new NpgsqlCommand(commandText, connection))
            {
                cmd.Parameters.AddWithValue("rut_admin", adm.rut_admin);
                cmd.Parameters.AddWithValue("pass", adm.pass);

                await cmd.ExecuteNonQueryAsync();
            }
            // falta tirar la excepcion si se agrega una llave foranea que no este en la base de datos
        }

        internal async Task AddCliente(Cliente cliente)
        {
            string commandText = $"insert into {cliente} (rut_cliente, rut_admin, tipo, nombre, descripcion) values (@rut_cliente, @rut_admin, @tipo, @nombre, @descripcion)";
            await using (var cmd = new NpgsqlCommand(commandText, connection))
            {
                cmd.Parameters.AddWithValue("rut_admin", cliente.rut_admin);
                cmd.Parameters.AddWithValue("rut_cliente", cliente.rut_cliente);
                cmd.Parameters.AddWithValue("tipo", cliente.tipo);
                cmd.Parameters.AddWithValue("nombre", cliente.nombre);
                cmd.Parameters.AddWithValue("descripcion", cliente.descripcion);

                await cmd.ExecuteNonQueryAsync();
            }
            // falta tirar la excepcion si se agrega una llave foranea que no este en la base de datos
        }

        internal async Task AddDocumento(Documento documento)
        {
            string commandText = $"insert into {documento} (id_documento, rut_cliente, tipo, fecha_modificacion) values (@id_documento, @rut_cliente, @tipo, @fecha_modificacion)";
            await using (var cmd = new NpgsqlCommand(commandText, connection))
            {
                cmd.Parameters.AddWithValue("id_documento", documento.id_documento);
                cmd.Parameters.AddWithValue("rut_cliente", documento.rut_cliente);
                cmd.Parameters.AddWithValue("tipo", documento.tipo);
                cmd.Parameters.AddWithValue("fecha_modificacion", documento.fecha_modificacion);

                await cmd.ExecuteNonQueryAsync();
            }
            // falta tirar la excepcion si se agrega una llave foranea que no este en la base de datos
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

        internal string login(string user)
        {
            Connect();
            string query = @"select pass from adm where user = adm.rut_admin";
            NpgsqlCommand cmd = new NpgsqlCommand(query);
            return "xd";
        }
    }
}