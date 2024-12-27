namespace WinFormsApp10
{
    partial class FormPrincipal
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
            btnListarProdutos = new Button();
            btnCadastroProduto = new Button();
            SuspendLayout();
            // 
            // btnListarProdutos
            // 
            btnListarProdutos.Location = new Point(96, 122);
            btnListarProdutos.Name = "btnListarProdutos";
            btnListarProdutos.Size = new Size(267, 182);
            btnListarProdutos.TabIndex = 0;
            btnListarProdutos.Text = "Listar Produtos";
            btnListarProdutos.UseVisualStyleBackColor = true;
            btnListarProdutos.Click += btnListarProdutos_Click;
            // 
            // btnCadastroProduto
            // 
            btnCadastroProduto.Location = new Point(441, 122);
            btnCadastroProduto.Name = "btnCadastroProduto";
            btnCadastroProduto.Size = new Size(270, 182);
            btnCadastroProduto.TabIndex = 1;
            btnCadastroProduto.Text = "Cadastro de Produtos";
            btnCadastroProduto.UseVisualStyleBackColor = true;
            btnCadastroProduto.Click += btnCadastroProduto_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastroProduto);
            Controls.Add(btnListarProdutos);
            Name = "FormPrincipal";
            Text = "Produtos do Felipe";
            ResumeLayout(false);
        }

        #endregion

        private Button btnListarProdutos;
        private Button btnCadastroProduto;
    }
}