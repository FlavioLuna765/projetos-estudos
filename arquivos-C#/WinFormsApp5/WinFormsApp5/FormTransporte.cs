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
    public partial class FormTransporte : Form
    {
        public FormTransporte()
        {
            InitializeComponent();
        }

        private void btnConfirmarTrasnporte_Click(object sender, EventArgs e)
        {

            string resultado = "";

            if(cbCarro.Checked)
            {
                resultado += " Carro";
            }

            if(cbAviao.Checked)
            {
                resultado += " Avião";
            }

            if (cbTrem.Checked) {
                resultado += " Trem";
            }

            txtTransporteResultado.Text = resultado;

        }
    }
}
