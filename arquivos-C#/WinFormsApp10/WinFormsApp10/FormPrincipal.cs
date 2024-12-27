﻿using System;
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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnCadastroProduto_Click(object sender, EventArgs e)
        {
            FormCadastro telaCadastro = new FormCadastro();
            telaCadastro.ShowDialog();
        }

        private void btnListarProdutos_Click(object sender, EventArgs e)
        {
            FormListarProduto telaListarProduto = new FormListarProduto();
            telaListarProduto.ShowDialog();
        }
    }
}
