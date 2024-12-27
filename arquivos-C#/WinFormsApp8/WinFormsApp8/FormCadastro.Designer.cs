namespace WinFormsApp8
{
    partial class FormCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblProduto = new Label();
            txtProduto = new TextBox();
            txtMarca = new TextBox();
            Marca = new Label();
            txtValor = new TextBox();
            lblPreco = new Label();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(207, 41);
            label1.Name = "label1";
            label1.Size = new Size(407, 54);
            label1.TabIndex = 0;
            label1.Text = "Cadastro de Produtos";
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Location = new Point(134, 150);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(50, 15);
            lblProduto.TabIndex = 1;
            lblProduto.Text = "Produto";
            // 
            // txtProduto
            // 
            txtProduto.Location = new Point(207, 147);
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(407, 23);
            txtProduto.TabIndex = 2;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(207, 209);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(407, 23);
            txtMarca.TabIndex = 4;
            // 
            // Marca
            // 
            Marca.AutoSize = true;
            Marca.Location = new Point(134, 212);
            Marca.Name = "Marca";
            Marca.Size = new Size(40, 15);
            Marca.TabIndex = 3;
            Marca.Text = "Marca";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(207, 272);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(407, 23);
            txtValor.TabIndex = 6;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(134, 275);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(33, 15);
            lblPreco.TabIndex = 5;
            lblPreco.Text = "Valor";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(207, 329);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(407, 64);
            btnCadastrar.TabIndex = 7;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastrar);
            Controls.Add(txtValor);
            Controls.Add(lblPreco);
            Controls.Add(txtMarca);
            Controls.Add(Marca);
            Controls.Add(txtProduto);
            Controls.Add(lblProduto);
            Controls.Add(label1);
            Name = "FormCadastro";
            Text = "FormCadastro";
            Load += FormCadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblProduto;
        private TextBox txtProduto;
        private TextBox txtMarca;
        private Label Marca;
        private TextBox txtValor;
        private Label lblPreco;
        private Button btnCadastrar;
    }
}