namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAperteAqui_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            lblResultado.Text = nome;

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int v1 = Int32.Parse(txtValor1.Text);
            int v2 = Int32.Parse(txtValor2.Text);

            int soma = v1 + v2;

            lblSoma.Text = soma.ToString();
        }
    }
}