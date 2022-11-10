using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_IngSoftware_Grupo_3
{
    internal class Cliente
    {
        public Cliente(string rut_cliente, string rut_admin, string tipo, string nombre, string descripcion)
        {
            this.rut_cliente = rut_cliente;
            this.rut_admin = rut_admin;
            this.tipo = tipo;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        public Cliente()
        {

        }

        public string rut_cliente { get; set; }
        public string rut_admin { get; set; }
        public string tipo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }

    }
}
