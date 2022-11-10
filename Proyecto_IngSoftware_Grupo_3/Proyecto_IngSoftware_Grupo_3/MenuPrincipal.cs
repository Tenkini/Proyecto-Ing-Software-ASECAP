using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_IngSoftware_Grupo_3
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void buttonDesplegarClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            DatosClientes dc = new DatosClientes();
            dc.Show();
        }

        private void buttonIngresarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrarCliente rc = new RegistrarCliente();
            rc.Show();
        }

        private void linkLabelCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }
    }
}
