namespace WinFormsApp5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnDestino_Click(object sender, EventArgs e)
        {
            FormDestino telaDestino = new FormDestino();
            telaDestino.ShowDialog();

        }

        private void btnTransporte_Click(object sender, EventArgs e)
        {
            FormTransporte telaTransporte = new FormTransporte();
            telaTransporte.ShowDialog();
        }

        private void btnInformacoes_Click(object sender, EventArgs e)
        {
            FormInformacoes telaInformacoes = new FormInformacoes();
            telaInformacoes.ShowDialog();
        }

        private void btnCalculoDesconto_Click(object sender, EventArgs e)
        {
            FormCalculoDesconto telaCalculoDesconto = new FormCalculoDesconto();
            telaCalculoDesconto.ShowDialog();
        }
    }
}