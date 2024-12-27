namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnApertar_Click(object sender, EventArgs e)
        {
            if (rbHomem.Checked)
            {
                lblResultado.Text = "Homem selecionado";
                lblResultado.Visible = true;
                MessageBox.Show("Homem Selecionado");
            }
            else if (rbMulher.Checked)
            {

                lblResultado.Text = "Mulher selecionado";
                lblResultado.Visible = true;
                MessageBox.Show("Mulher Selecionado");
            }
            else {

                lblResultado.Visible = false;
                
            }
        }
    }
}