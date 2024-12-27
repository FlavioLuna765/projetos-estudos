namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            string tamanho = "";
            string pagamento = "";
            string adicionais = "";
            string sabores = "";

            if (rbPequena.Checked)
            {
                tamanho = "Pequena";
            }
            else if (rbMedia.Checked)
            {
                tamanho = "Média";
            }
            else if (rbGrande.Checked)
            {
                tamanho = "Grande";
            }
            else
            {
                tamanho = "Pequena";
            }

            if (rbCartao.Checked)
            {
                pagamento = "Cartão";
            }
            else if (rbDinheiro.Checked)
            {
                pagamento = "Dinheiro";
            }
            else
            {
                pagamento = "Dinheiro";
            }


            if (!chkQueijo.Checked && !chkBorda.Checked && !chkBacon.Checked)
            {
                adicionais = "Sem Adicionais";
            }
            else
            {
                if (chkQueijo.Checked)
                {
                    adicionais += "Queijo";
                }

                if (chkBorda.Checked)
                {
                    adicionais += "Borda";
                }

                if (chkBacon.Checked)
                {
                    adicionais += "Bacon";
                }
            }


            sabores = cmbSabor.SelectedItem.ToString();




            MessageBox.Show(
                    "Tamanho " + tamanho +
                    "\n Sabor: " + sabores +
                    "\n Adicionais: " + adicionais +
                    "\n Pagamento: " + pagamento
                );

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbSabor.SelectedIndex = 0;
        }
    }
}