namespace WinFormsApp5
{
    partial class FormCalculoDesconto
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
            btnConfirmarCalcularDesconto = new Button();
            txtResultado = new TextBox();
            lblParcelas = new Label();
            txtValorDoProduto = new TextBox();
            lblValor = new Label();
            gbParcelamentos = new GroupBox();
            rb4a12Parcelas = new RadioButton();
            rbAte3Parcelas = new RadioButton();
            rbAVista = new RadioButton();
            textBox1 = new TextBox();
            gbParcelamentos.SuspendLayout();
            SuspendLayout();
            // 
            // btnConfirmarCalcularDesconto
            // 
            btnConfirmarCalcularDesconto.Location = new Point(309, 397);
            btnConfirmarCalcularDesconto.Name = "btnConfirmarCalcularDesconto";
            btnConfirmarCalcularDesconto.Size = new Size(266, 82);
            btnConfirmarCalcularDesconto.TabIndex = 13;
            btnConfirmarCalcularDesconto.Text = "Confirmar";
            btnConfirmarCalcularDesconto.UseVisualStyleBackColor = true;
            btnConfirmarCalcularDesconto.Click += btnConfirmarCalcularDesconto_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(292, 528);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(303, 23);
            txtResultado.TabIndex = 12;
            // 
            // lblParcelas
            // 
            lblParcelas.AutoSize = true;
            lblParcelas.Location = new Point(196, 145);
            lblParcelas.Name = "lblParcelas";
            lblParcelas.Size = new Size(181, 15);
            lblParcelas.TabIndex = 9;
            lblParcelas.Text = "Escolha a quantidade de parcelas";
            lblParcelas.Click += lblParcelas_Click;
            // 
            // txtValorDoProduto
            // 
            txtValorDoProduto.Location = new Point(371, 69);
            txtValorDoProduto.Name = "txtValorDoProduto";
            txtValorDoProduto.Size = new Size(303, 23);
            txtValorDoProduto.TabIndex = 8;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(196, 72);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(140, 15);
            lblValor.TabIndex = 7;
            lblValor.Text = "Digite o Valor do Produto";
            // 
            // gbParcelamentos
            // 
            gbParcelamentos.Controls.Add(rb4a12Parcelas);
            gbParcelamentos.Controls.Add(rbAte3Parcelas);
            gbParcelamentos.Controls.Add(rbAVista);
            gbParcelamentos.Location = new Point(196, 174);
            gbParcelamentos.Name = "gbParcelamentos";
            gbParcelamentos.Size = new Size(365, 178);
            gbParcelamentos.TabIndex = 14;
            gbParcelamentos.TabStop = false;
            // 
            // rb4a12Parcelas
            // 
            rb4a12Parcelas.AutoSize = true;
            rb4a12Parcelas.Location = new Point(31, 125);
            rb4a12Parcelas.Name = "rb4a12Parcelas";
            rb4a12Parcelas.Size = new Size(228, 19);
            rb4a12Parcelas.TabIndex = 2;
            rb4a12Parcelas.TabStop = true;
            rb4a12Parcelas.Text = "Entre 4 e 12 parcelas com juros de 10%";
            rb4a12Parcelas.UseVisualStyleBackColor = true;
            // 
            // rbAte3Parcelas
            // 
            rbAte3Parcelas.AutoSize = true;
            rbAte3Parcelas.Location = new Point(31, 83);
            rbAte3Parcelas.Name = "rbAte3Parcelas";
            rbAte3Parcelas.Size = new Size(175, 19);
            rbAte3Parcelas.TabIndex = 1;
            rbAte3Parcelas.TabStop = true;
            rbAte3Parcelas.Text = "Até 3 parcelas sem desconto";
            rbAte3Parcelas.UseVisualStyleBackColor = true;
            // 
            // rbAVista
            // 
            rbAVista.AutoSize = true;
            rbAVista.Location = new Point(31, 40);
            rbAVista.Name = "rbAVista";
            rbAVista.Size = new Size(180, 19);
            rbAVista.TabIndex = 0;
            rbAVista.TabStop = true;
            rbAVista.Text = "À vista com 10% de desconto";
            rbAVista.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(660, 344);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(279, 23);
            textBox1.TabIndex = 15;
            // 
            // FormCalculoDesconto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 616);
            Controls.Add(textBox1);
            Controls.Add(gbParcelamentos);
            Controls.Add(btnConfirmarCalcularDesconto);
            Controls.Add(txtResultado);
            Controls.Add(lblParcelas);
            Controls.Add(txtValorDoProduto);
            Controls.Add(lblValor);
            Name = "FormCalculoDesconto";
            Text = "FormCalculoDesconto";
            gbParcelamentos.ResumeLayout(false);
            gbParcelamentos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirmarCalcularDesconto;
        private TextBox txtResultado;
        private TextBox txtEmail;
        private Label lblParcelas;
        private TextBox txtValorDoProduto;
        private Label lblValor;
        private GroupBox gbParcelamentos;
        private RadioButton rb4a12Parcelas;
        private RadioButton rbAte3Parcelas;
        private RadioButton rbAVista;
        private TextBox textBox1;
    }
}