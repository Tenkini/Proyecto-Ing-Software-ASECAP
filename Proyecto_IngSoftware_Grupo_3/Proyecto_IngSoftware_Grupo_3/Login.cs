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

            string user = textBoxRut.Text;
            string pass = textBoxPassword.Text;

            LoginService ls = new LoginService();

            if (ls.ValidateLogin(user, pass))
            {
                this.Hide();
                MenuPrincipal mp = new MenuPrincipal();
                mp.Show();
            }
            else MessageBox.Show("Login invalido");
        }
    }
}