namespace WinFormsApp10
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
            btnSalvarProduto = new Button();
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            txtNomeProduto = new TextBox();
            lblNomeProduto = new Label();
            txtPreco = new TextBox();
            lblPreco = new Label();
            SuspendLayout();
            // 
            // btnSalvarProduto
            // 
            btnSalvarProduto.Location = new Point(266, 311);
            btnSalvarProduto.Name = "btnSalvarProduto";
            btnSalvarProduto.Size = new Size(256, 71);
            btnSalvarProduto.TabIndex = 0;
            btnSalvarProduto.Text = "Salvar Produto";
            btnSalvarProduto.UseVisualStyleBackColor = true;
            btnSalvarProduto.Click += btnSalvarProduto_Click;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(190, 96);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(320, 93);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(262, 23);
            txtCodigo.TabIndex = 2;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(320, 154);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(262, 23);
            txtNomeProduto.TabIndex = 4;
            // 
            // lblNomeProduto
            // 
            lblNomeProduto.AutoSize = true;
            lblNomeProduto.Location = new Point(190, 157);
            lblNomeProduto.Name = "lblNomeProduto";
            lblNomeProduto.Size = new Size(86, 15);
            lblNomeProduto.TabIndex = 3;
            lblNomeProduto.Text = "Nome Produto";
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(320, 217);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(262, 23);
            txtPreco.TabIndex = 6;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(190, 220);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(37, 15);
            lblPreco.TabIndex = 5;
            lblPreco.Text = "Preço";
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPreco);
            Controls.Add(lblPreco);
            Controls.Add(txtNomeProduto);
            Controls.Add(lblNomeProduto);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            Controls.Add(btnSalvarProduto);
            Name = "FormCadastro";
            Text = "Cadastro Produto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvarProduto;
        private Label lblCodigo;
        private TextBox txtCodigo;
        private TextBox txtNomeProduto;
        private Label lblNomeProduto;
        private TextBox txtPreco;
        private Label lblPreco;
    }
}