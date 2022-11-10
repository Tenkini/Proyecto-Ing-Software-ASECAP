namespace Proyecto_IngSoftware_Grupo_3
{
    public partial class Login : Form
    {
        private Rectangle loginOriginalRect;
        
        private Rectangle imagenLogoOriginalRect;
        private Rectangle textBoxRutOriginalRect;
        private Rectangle textBoxPasswordOriginalRect;
        private Rectangle buttonConfirmarOriginalRect;

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

        private void Login_Load(object sender, EventArgs e)
        {
            loginOriginalRect = new Rectangle(this.Location, this.Size);

            imagenLogoOriginalRect = new Rectangle(imagenLogo.Location, imagenLogo.Size);
            textBoxRutOriginalRect = new Rectangle(textBoxRut.Location, textBoxRut.Size);
            textBoxPasswordOriginalRect = new Rectangle(textBoxPassword.Location, textBoxPassword.Size);
            buttonConfirmarOriginalRect = new Rectangle(buttonConfirmar.Location, buttonConfirmar.Size);

            LoginResize();
        }

        private void LoginResize()
        {
            ResizeService rs = new ResizeService();

            rs.ResizeControl(imagenLogo, imagenLogoOriginalRect, this, loginOriginalRect);
            rs.ResizeControl(textBoxRut, textBoxRutOriginalRect, this, loginOriginalRect);
            rs.ResizeControl(textBoxPassword, textBoxPasswordOriginalRect, this, loginOriginalRect);
            rs.ResizeControl(buttonConfirmar, buttonConfirmarOriginalRect, this, loginOriginalRect);

        }
    }
}