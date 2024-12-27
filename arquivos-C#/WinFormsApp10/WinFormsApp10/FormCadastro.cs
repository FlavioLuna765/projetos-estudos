using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp10
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        private void btnSalvarProduto_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto {
                Codigo = int.Parse(txtCodigo.Text),
                Nome = txtNomeProduto.Text,
                Preco = float.Parse(txtPreco.Text)
            };

            Dados.lista.Add(produto);

            MessageBox.Show("Mensagem cadastrada com sucesso");
        }
    }
}
