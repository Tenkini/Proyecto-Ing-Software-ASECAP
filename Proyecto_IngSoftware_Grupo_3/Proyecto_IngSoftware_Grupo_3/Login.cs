namespace Proyecto_IngSoftware_Grupo_3
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal mp = new MenuPrincipal();
            mp.Show();
        }
    }
}