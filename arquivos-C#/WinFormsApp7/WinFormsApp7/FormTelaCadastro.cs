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
    public partial class FormTelaCadastro : Form
    {
        public FormTelaCadastro()
        {
            InitializeComponent();
        }

        private void btnSalvarProduto_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" && txtNomeProduto.Text == "" && txtPreco.Text == "")
            {
                MessageBox.Show("Tem algum em branco");
            }
            else { 
            
                    //Vou fazer
            
            }
        }
    }
}
