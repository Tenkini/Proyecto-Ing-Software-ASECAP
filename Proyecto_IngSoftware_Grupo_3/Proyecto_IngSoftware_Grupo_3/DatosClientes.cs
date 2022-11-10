using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Proyecto_IngSoftware_Grupo_3
{
    public partial class DatosClientes : Form
    {
        public DatosClientes()
        {
            InitializeComponent();
            ShowClientesService scs = new ShowClientesService();
            dataGridView1.DataSource = scs.ShowClients();
        }

        public static implicit operator DatosClientes(MenuPrincipal v)
        {
            throw new NotImplementedException();
        }

        private void backLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            MenuPrincipal mp = new MenuPrincipal();
            mp.Show();
        }
    }
}
