using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            double v1, v2, resultado;

            v1 = Double.Parse(txtValor1.Text);
            v2 = Double.Parse(txtValor2.Text);

            resultado = v1 + v2;

            lblResultado.Text = resultado.ToString();

        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            double v1, v2, resultado;

            v1 = Double.Parse(txtValor1.Text);
            v2 = Double.Parse(txtValor2.Text);

            resultado = v1 - v2;

            lblResultado.Text = resultado.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double v1, v2, resultado;

            v1 = Double.Parse(txtValor1.Text);
            v2 = Double.Parse(txtValor2.Text);

            resultado = v1 * v2;

            lblResultado.Text = resultado.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double v1, v2, resultado;

            v1 = Double.Parse(txtValor1.Text);
            v2 = Double.Parse(txtValor2.Text);

            resultado = v1 / v2;

            lblResultado.Text = resultado.ToString();
        }
    }
}
