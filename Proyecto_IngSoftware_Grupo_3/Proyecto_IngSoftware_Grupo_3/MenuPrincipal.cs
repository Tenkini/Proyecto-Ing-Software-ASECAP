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

        private void buttonSearchClient_Click(object sender, EventArgs e)
        {
            //falta buscar con un solo nombre y buscar
            //quiza mejor juntar pantallas para ver algo mas directo
            //falta normalizar los textos que entran y que salen
            SearchClientByParamService scp = new SearchClientByParamService();
            string param = textBoxBuscarCliente.Text;

            if (scp.existsClientByRut(param) || scp.existsClientByName(param))
            {
                this.Hide();
                ClientInfoDisplay ci = new ClientInfoDisplay();
                ci.Show();
            }

            else
            {
                MessageBox.Show("Cliente con esos datos no existe");
            }
        }
    }
}
