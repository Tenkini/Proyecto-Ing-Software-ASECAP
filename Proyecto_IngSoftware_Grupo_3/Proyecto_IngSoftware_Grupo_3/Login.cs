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

            String user = textBoxRut.Text;
            String pass = textBoxPassword.Text;

            LoginService ls = new LoginService();

            if (!ls.validateLogin(user, pass)) MessageBox.Show("Login invalido");
            else
            {
                this.Hide();
                MenuPrincipal mp = new MenuPrincipal();
                mp.Show();
            }
        }
    }
}