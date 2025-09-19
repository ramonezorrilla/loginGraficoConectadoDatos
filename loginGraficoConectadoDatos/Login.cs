using CapaNegocios;

namespace loginGraficoConectadoDatos
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            string usuario = txtusuario.Text;
            string clave = txtclave.Text;
            if (CN_Login.ValidarLogin(usuario, clave))
            {
                MessageBox.Show("Bienvenido", "Login realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            { 
                MessageBox.Show("Login fallido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
