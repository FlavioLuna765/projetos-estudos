namespace WinFormsApp3
{
    partial class Form2
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
            txtValor1 = new TextBox();
            txtValor2 = new TextBox();
            rbAdicao = new RadioButton();
            rbSubtracao = new RadioButton();
            rbMultiplicacao = new RadioButton();
            rbDivisao = new RadioButton();
            btnCalcular = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(187, 30);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(376, 23);
            txtValor1.TabIndex = 0;
            // 
            // txtValor2
            // 
            txtValor2.Location = new Point(187, 83);
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new Size(376, 23);
            txtValor2.TabIndex = 1;
            // 
            // rbAdicao
            // 
            rbAdicao.AutoSize = true;
            rbAdicao.Location = new Point(241, 136);
            rbAdicao.Name = "rbAdicao";
            rbAdicao.Size = new Size(33, 19);
            rbAdicao.TabIndex = 2;
            rbAdicao.TabStop = true;
            rbAdicao.Text = "+";
            rbAdicao.UseVisualStyleBackColor = true;
            rbAdicao.CheckedChanged += rbAdicao_CheckedChanged;
            // 
            // rbSubtracao
            // 
            rbSubtracao.AutoSize = true;
            rbSubtracao.Location = new Point(328, 137);
            rbSubtracao.Name = "rbSubtracao";
            rbSubtracao.Size = new Size(30, 19);
            rbSubtracao.TabIndex = 3;
            rbSubtracao.TabStop = true;
            rbSubtracao.Text = "-";
            rbSubtracao.UseVisualStyleBackColor = true;
            rbSubtracao.CheckedChanged += rbSubtracao_CheckedChanged;
            // 
            // rbMultiplicacao
            // 
            rbMultiplicacao.AutoSize = true;
            rbMultiplicacao.Location = new Point(398, 137);
            rbMultiplicacao.Name = "rbMultiplicacao";
            rbMultiplicacao.Size = new Size(30, 19);
            rbMultiplicacao.TabIndex = 4;
            rbMultiplicacao.TabStop = true;
            rbMultiplicacao.Text = "*";
            rbMultiplicacao.UseVisualStyleBackColor = true;
            rbMultiplicacao.CheckedChanged += rbMultiplicacao_CheckedChanged;
            // 
            // rbDivisao
            // 
            rbDivisao.AutoSize = true;
            rbDivisao.Location = new Point(481, 137);
            rbDivisao.Name = "rbDivisao";
            rbDivisao.Size = new Size(30, 19);
            rbDivisao.TabIndex = 5;
            rbDivisao.TabStop = true;
            rbDivisao.Text = "/";
            rbDivisao.UseVisualStyleBackColor = true;
            rbDivisao.CheckedChanged += rbDivisao_CheckedChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(338, 197);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(354, 268);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 7;
            lblResultado.Text = "Resultado";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 353);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(rbDivisao);
            Controls.Add(rbMultiplicacao);
            Controls.Add(rbSubtracao);
            Controls.Add(rbAdicao);
            Controls.Add(txtValor2);
            Controls.Add(txtValor1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtValor1;
        private TextBox txtValor2;
        private RadioButton rbAdicao;
        private RadioButton rbSubtracao;
        private RadioButton rbMultiplicacao;
        private RadioButton rbDivisao;
        private Button btnCalcular;
        private Label lblResultado;
    }
}