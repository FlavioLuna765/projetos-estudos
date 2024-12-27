using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            /*double valor1, valor2, resultado;

            valor1 = Double.Parse(txtValor1.Text);
            valor2 = Double.Parse(txtValor2.Text);

            if (rbAdicao.Checked)
            {
                resultado = valor1 + valor2;
                lblResultado.Text = resultado.ToString();
            }
            else if (rbSubtracao.Checked)
            {
                resultado = valor1 - valor2;
                lblResultado.Text = resultado.ToString();
            }
            else if (rbMultiplicacao.Checked)
            {
                resultado = valor1 * valor2;
                lblResultado.Text = resultado.ToString();
            }
            else if (rbDivisao.Checked)
            {
                resultado = valor1 / valor2;
                lblResultado.Text = resultado.ToString();
            }
            else
            {

                lblResultado.Visible = false;
            }*/
        }

        private void rbAdicao_CheckedChanged(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;

            valor1 = Double.Parse(txtValor1.Text);
            valor2 = Double.Parse(txtValor2.Text);

            resultado = valor1 + valor2;
            lblResultado.Text = resultado.ToString();
        }

        private void rbSubtracao_CheckedChanged(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;

            valor1 = Double.Parse(txtValor1.Text);
            valor2 = Double.Parse(txtValor2.Text);

            resultado = valor1 - valor2;
            lblResultado.Text = resultado.ToString();
        }

        private void rbMultiplicacao_CheckedChanged(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;

            valor1 = Double.Parse(txtValor1.Text);
            valor2 = Double.Parse(txtValor2.Text);

            resultado = valor1 * valor2;
            lblResultado.Text = resultado.ToString();
        }

        private void rbDivisao_CheckedChanged(object sender, EventArgs e)
        {
            double valor1, valor2, resultado;

            valor1 = Double.Parse(txtValor1.Text);
            valor2 = Double.Parse(txtValor2.Text);

            resultado = valor1 / valor2;
            lblResultado.Text = resultado.ToString();
        }
    }
}
