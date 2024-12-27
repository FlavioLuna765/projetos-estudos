namespace WinFormsApp5
{
    partial class FormDestino
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
            lblDestino = new Label();
            gbDestino = new GroupBox();
            rbPraia = new RadioButton();
            rbMontanha = new RadioButton();
            rbCidade = new RadioButton();
            btnConfirmarDestino = new Button();
            gbDestino.SuspendLayout();
            SuspendLayout();
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            lblDestino.Location = new Point(36, 47);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(732, 72);
            lblDestino.TabIndex = 0;
            lblDestino.Text = "Escolha seu destino preferido";
            // 
            // gbDestino
            // 
            gbDestino.Controls.Add(rbCidade);
            gbDestino.Controls.Add(rbMontanha);
            gbDestino.Controls.Add(rbPraia);
            gbDestino.Location = new Point(215, 152);
            gbDestino.Name = "gbDestino";
            gbDestino.Size = new Size(365, 178);
            gbDestino.TabIndex = 1;
            gbDestino.TabStop = false;
            gbDestino.Text = "Destinos";
            // 
            // rbPraia
            // 
            rbPraia.AutoSize = true;
            rbPraia.Location = new Point(31, 40);
            rbPraia.Name = "rbPraia";
            rbPraia.Size = new Size(51, 19);
            rbPraia.TabIndex = 0;
            rbPraia.TabStop = true;
            rbPraia.Text = "Praia";
            rbPraia.UseVisualStyleBackColor = true;
            // 
            // rbMontanha
            // 
            rbMontanha.AutoSize = true;
            rbMontanha.Location = new Point(31, 83);
            rbMontanha.Name = "rbMontanha";
            rbMontanha.Size = new Size(80, 19);
            rbMontanha.TabIndex = 1;
            rbMontanha.TabStop = true;
            rbMontanha.Text = "Montanha";
            rbMontanha.UseVisualStyleBackColor = true;
            // 
            // rbCidade
            // 
            rbCidade.AutoSize = true;
            rbCidade.Location = new Point(31, 125);
            rbCidade.Name = "rbCidade";
            rbCidade.Size = new Size(62, 19);
            rbCidade.TabIndex = 2;
            rbCidade.TabStop = true;
            rbCidade.Text = "Cidade";
            rbCidade.UseVisualStyleBackColor = true;
            // 
            // btnConfirmarDestino
            // 
            btnConfirmarDestino.Location = new Point(302, 367);
            btnConfirmarDestino.Name = "btnConfirmarDestino";
            btnConfirmarDestino.Size = new Size(211, 51);
            btnConfirmarDestino.TabIndex = 2;
            btnConfirmarDestino.Text = "Confirmar";
            btnConfirmarDestino.UseVisualStyleBackColor = true;
            btnConfirmarDestino.Click += btnConfirmarDestino_Click;
            // 
            // FormDestino
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConfirmarDestino);
            Controls.Add(gbDestino);
            Controls.Add(lblDestino);
            Name = "FormDestino";
            Text = "Destino";
            gbDestino.ResumeLayout(false);
            gbDestino.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDestino;
        private GroupBox gbDestino;
        private RadioButton rbCidade;
        private RadioButton rbMontanha;
        private RadioButton rbPraia;
        private Button btnConfirmarDestino;
    }
}