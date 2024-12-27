namespace WinFormsApp7
{
    partial class FormTelaPrincipal
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
            btnCadastroProduto = new Button();
            btnListarProdutos = new Button();
            SuspendLayout();
            // 
            // btnCadastroProduto
            // 
            btnCadastroProduto.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastroProduto.Location = new Point(79, 109);
            btnCadastroProduto.Name = "btnCadastroProduto";
            btnCadastroProduto.Size = new Size(229, 134);
            btnCadastroProduto.TabIndex = 0;
            btnCadastroProduto.Text = "Cadastro";
            btnCadastroProduto.UseVisualStyleBackColor = true;
            btnCadastroProduto.Click += btnCadastroProduto_Click;
            // 
            // btnListarProdutos
            // 
            btnListarProdutos.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnListarProdutos.Location = new Point(432, 110);
            btnListarProdutos.Name = "btnListarProdutos";
            btnListarProdutos.Size = new Size(227, 133);
            btnListarProdutos.TabIndex = 1;
            btnListarProdutos.Text = "Listar produto";
            btnListarProdutos.UseVisualStyleBackColor = true;
            btnListarProdutos.Click += btnListarProdutos_Click;
            // 
            // FormTelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(800, 450);
            Controls.Add(btnListarProdutos);
            Controls.Add(btnCadastroProduto);
            Name = "FormTelaPrincipal";
            Text = "Tela Principal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCadastroProduto;
        private Button btnListarProdutos;
    }
}