namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Admin" && txtSenha.Text == "1234")
            {

                FormTelaPrincipal telaPrincipal = new FormTelaPrincipal();
                telaPrincipal.ShowDialog();

            }
            else
            {

                MessageBox.Show("Usuário ou Senha estão incorretos");

            }
        }
    }
}