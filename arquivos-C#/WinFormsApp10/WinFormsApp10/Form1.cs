namespace WinFormsApp10
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

                FormPrincipal telaPrincipal = new FormPrincipal();
                telaPrincipal.Show();

            }
            else {

                MessageBox.Show("Errouuuuuuuuuuuuuuu");
            }
        }
    }
}