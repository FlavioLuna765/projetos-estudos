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
    public partial class FormInformacoes : Form
    {
        public FormInformacoes()
        {
            InitializeComponent();
        }

        private void btnConfirmarInformacoes_Click(object sender, EventArgs e)
        {

            if(txtNome.Text != "" && txtEmail.Text != "" && txtTelefone.Text != "")
            {
                string nome = txtNome.Text;
                string email = txtEmail.Text;
                string telefone = txtTelefone.Text;

                MessageBox.Show($"Nome: {nome} \n E-mail: {email} \n Telefone: {telefone}");
            }
            else
            {
                MessageBox.Show("Preencha os campos");
            }

            



        }
    }
}
