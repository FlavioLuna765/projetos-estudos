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
    public partial class FormListarProduto : Form
    {
        public FormListarProduto()
        {
            InitializeComponent();
        }

        private void FormListarProduto_Load(object sender, EventArgs e)
        {
            dgvProdutos.DataSource = Dados.lista;
        }
    }
}
