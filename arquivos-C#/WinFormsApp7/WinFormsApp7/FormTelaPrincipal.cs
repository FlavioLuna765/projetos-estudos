using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp7
{
    public partial class FormTelaPrincipal : Form
    {
        public FormTelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnCadastroProduto_Click(object sender, EventArgs e)
        {
            FormTelaCadastro telaCadastro = new FormTelaCadastro();
            telaCadastro.ShowDialog();
        }

        private void btnListarProdutos_Click(object sender, EventArgs e)
        {
            FormTelaListar telaListar = new FormTelaListar();
            telaListar.ShowDialog();
        }
    }
}
