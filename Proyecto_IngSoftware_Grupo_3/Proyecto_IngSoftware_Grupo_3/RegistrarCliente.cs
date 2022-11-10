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
    public partial class RegistrarCliente : Form
    {
        public RegistrarCliente()
        {
            InitializeComponent();
        }

        private void backLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            MenuPrincipal mp = new MenuPrincipal();
            mp.Show();
        }

        private void buttonConfirmacionIngresoCliente_Click(object sender, EventArgs e)
        {
            string nombreCliente = textBoxIngresoNombreCliente.Text;
            string rutCliente = textBoxIngresoRutCliente.Text;
            string tipoCliente = textBoxIngresoTipoCliente.Text;
            string descripcionCliente = textBoxIngresoDescripcionCliente.Text;

            AddClienteService acs = new AddClienteService();
            acs.addClient(rutCliente, nombreCliente, tipoCliente, descripcionCliente);
            MessageBox.Show("Ingreso Exitoso");

            //falta poner excepciones cuando se ingrese un usuario repetido
            //falta poner triggers para normalizar el estilo de las palabras
        }
    }
}
