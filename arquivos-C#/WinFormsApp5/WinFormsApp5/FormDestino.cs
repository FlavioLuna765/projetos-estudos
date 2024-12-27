using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class FormDestino : Form
    {
        public FormDestino()
        {
            InitializeComponent();
        }

        private void btnConfirmarDestino_Click(object sender, EventArgs e)
        {
            if (rbPraia.Checked)
            {

                MessageBox.Show("Seu destino preferido é a Praia");
            }
            else if (rbMontanha.Checked)
            {

                MessageBox.Show("Seu destino preferido é a Montanha");
            }
            else if (rbCidade.Checked)
            {
                MessageBox.Show("Seu destino preferido é a Cidade");
            }
            else {
                MessageBox.Show("Selecione o destino preferido");
            }
        }
    }
}
