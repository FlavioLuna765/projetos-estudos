namespace WinFormsApp3
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
            rbHomem = new RadioButton();
            rbMulher = new RadioButton();
            lblResultado = new Label();
            btnApertar = new Button();
            SuspendLayout();
            // 
            // rbHomem
            // 
            rbHomem.AutoSize = true;
            rbHomem.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            rbHomem.Location = new Point(91, 128);
            rbHomem.Name = "rbHomem";
            rbHomem.Size = new Size(181, 58);
            rbHomem.TabIndex = 0;
            rbHomem.TabStop = true;
            rbHomem.Text = "Homem";
            rbHomem.UseVisualStyleBackColor = true;
            // 
            // rbMulher
            // 
            rbMulher.AutoSize = true;
            rbMulher.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            rbMulher.Location = new Point(480, 128);
            rbMulher.Name = "rbMulher";
            rbMulher.Size = new Size(168, 58);
            rbMulher.TabIndex = 1;
            rbMulher.TabStop = true;
            rbMulher.Text = "Mulher";
            rbMulher.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.Location = new Point(324, 361);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(130, 54);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "label1";
            lblResultado.Visible = false;
            // 
            // btnApertar
            // 
            btnApertar.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnApertar.Location = new Point(240, 242);
            btnApertar.Name = "btnApertar";
            btnApertar.Size = new Size(269, 87);
            btnApertar.TabIndex = 3;
            btnApertar.Text = "Aperte Aqui";
            btnApertar.UseVisualStyleBackColor = true;
            btnApertar.Click += btnApertar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnApertar);
            Controls.Add(lblResultado);
            Controls.Add(rbMulher);
            Controls.Add(rbHomem);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbHomem;
        private RadioButton rbMulher;
        private Label lblResultado;
        private Button btnApertar;
    }
}