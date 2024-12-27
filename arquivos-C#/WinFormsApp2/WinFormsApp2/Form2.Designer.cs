namespace WinFormsApp2
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
            btnSomar = new Button();
            btnSubtrair = new Button();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            txtValor1 = new TextBox();
            txtValor2 = new TextBox();
            lblValor1 = new Label();
            lblValor2 = new Label();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // btnSomar
            // 
            btnSomar.Location = new Point(114, 272);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(75, 23);
            btnSomar.TabIndex = 0;
            btnSomar.Text = "Somar";
            btnSomar.UseVisualStyleBackColor = true;
            btnSomar.Click += btnSomar_Click;
            // 
            // btnSubtrair
            // 
            btnSubtrair.Location = new Point(255, 272);
            btnSubtrair.Name = "btnSubtrair";
            btnSubtrair.Size = new Size(75, 23);
            btnSubtrair.TabIndex = 1;
            btnSubtrair.Text = "Subtrair";
            btnSubtrair.UseVisualStyleBackColor = true;
            btnSubtrair.Click += btnSubtrair_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(417, 275);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(75, 23);
            btnMultiplicar.TabIndex = 2;
            btnMultiplicar.Text = "Multiplicar";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(582, 276);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(75, 23);
            btnDividir.TabIndex = 3;
            btnDividir.Text = "Dividir";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(202, 83);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(500, 23);
            txtValor1.TabIndex = 4;
            // 
            // txtValor2
            // 
            txtValor2.Location = new Point(202, 161);
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new Size(500, 23);
            txtValor2.TabIndex = 5;
            // 
            // lblValor1
            // 
            lblValor1.AutoSize = true;
            lblValor1.Location = new Point(104, 86);
            lblValor1.Name = "lblValor1";
            lblValor1.Size = new Size(76, 15);
            lblValor1.TabIndex = 6;
            lblValor1.Text = "Digite Valor 1";
            // 
            // lblValor2
            // 
            lblValor2.AutoSize = true;
            lblValor2.Location = new Point(107, 170);
            lblValor2.Name = "lblValor2";
            lblValor2.Size = new Size(76, 15);
            lblValor2.TabIndex = 7;
            lblValor2.Text = "Digite Valor 2";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.Location = new Point(282, 354);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(198, 54);
            lblResultado.TabIndex = 8;
            lblResultado.Text = "Resultado";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(lblValor2);
            Controls.Add(lblValor1);
            Controls.Add(txtValor2);
            Controls.Add(txtValor1);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnSubtrair);
            Controls.Add(btnSomar);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSomar;
        private Button btnSubtrair;
        private Button btnMultiplicar;
        private Button btnDividir;
        private TextBox txtValor1;
        private TextBox txtValor2;
        private Label lblValor1;
        private Label lblValor2;
        private Label lblResultado;
    }
}