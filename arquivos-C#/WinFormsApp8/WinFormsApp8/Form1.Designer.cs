namespace WinFormsApp8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblLoja = new Label();
            btnNovoCadastro = new Button();
            btnAtualizar = new Button();
            dgvProdutos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // lblLoja
            // 
            lblLoja.AutoSize = true;
            lblLoja.Font = new Font("Segoe UI", 50F, FontStyle.Regular, GraphicsUnit.Point);
            lblLoja.Location = new Point(316, 27);
            lblLoja.Name = "lblLoja";
            lblLoja.Size = new Size(159, 89);
            lblLoja.TabIndex = 0;
            lblLoja.Text = "Loja";
            // 
            // btnNovoCadastro
            // 
            btnNovoCadastro.Location = new Point(117, 158);
            btnNovoCadastro.Name = "btnNovoCadastro";
            btnNovoCadastro.Size = new Size(206, 58);
            btnNovoCadastro.TabIndex = 1;
            btnNovoCadastro.Text = "Novo Cadastro";
            btnNovoCadastro.UseVisualStyleBackColor = true;
            btnNovoCadastro.Click += btnNovoCadastro_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(481, 158);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(206, 58);
            btnAtualizar.TabIndex = 2;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // dgvProdutos
            // 
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(117, 280);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.RowTemplate.Height = 25;
            dgvProdutos.Size = new Size(570, 248);
            dgvProdutos.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 592);
            Controls.Add(dgvProdutos);
            Controls.Add(btnAtualizar);
            Controls.Add(btnNovoCadastro);
            Controls.Add(lblLoja);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLoja;
        private Button btnNovoCadastro;
        private Button btnAtualizar;
        private DataGridView dgvProdutos;
    }
}