namespace WinFormsApp7
{
    partial class FormTelaCadastro
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
            lblNomeProduto = new Label();
            lblPreco = new Label();
            txtCodigo = new TextBox();
            txtNomeProduto = new TextBox();
            txtPreco = new TextBox();
            SuspendLayout();
            // 
            // btnSalvarProduto
            // 
            btnSalvarProduto.Location = new Point(230, 238);
            btnSalvarProduto.Name = "btnSalvarProduto";
            btnSalvarProduto.Size = new Size(100, 23);
            btnSalvarProduto.TabIndex = 0;
            btnSalvarProduto.Text = "Salvar";
            btnSalvarProduto.UseVisualStyleBackColor = true;
            btnSalvarProduto.Click += btnSalvarProduto_Click;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(141, 61);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Código";
            // 
            // lblNomeProduto
            // 
            lblNomeProduto.AutoSize = true;
            lblNomeProduto.Location = new Point(84, 116);
            lblNomeProduto.Name = "lblNomeProduto";
            lblNomeProduto.Size = new Size(103, 15);
            lblNomeProduto.TabIndex = 3;
            lblNomeProduto.Text = "Nome do Produto";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(141, 175);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(37, 15);
            lblPreco.TabIndex = 5;
            lblPreco.Text = "Preço";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(230, 61);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 6;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(230, 113);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(100, 23);
            txtNomeProduto.TabIndex = 7;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(230, 172);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(100, 23);
            txtPreco.TabIndex = 8;
            // 
            // FormTelaCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 306);
            Controls.Add(txtPreco);
            Controls.Add(txtNomeProduto);
            Controls.Add(txtCodigo);
            Controls.Add(lblPreco);
            Controls.Add(lblNomeProduto);
            Controls.Add(lblCodigo);
            Controls.Add(btnSalvarProduto);
            Name = "FormTelaCadastro";
            Text = "FormTelaCadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvarProduto;
        private Label lblCodigo;
        private Label lblNomeProduto;
        private Label lblPreco;
        private TextBox txtCodigo;
        private TextBox txtNomeProduto;
        private TextBox txtPreco;
    }
}