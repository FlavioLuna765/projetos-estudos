namespace WinFormsApp5
{
    partial class FormTransporte
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
            btnConfirmarTrasnporte = new Button();
            gbTransporte = new GroupBox();
            lblTransporte = new Label();
            cbCarro = new CheckBox();
            cbAviao = new CheckBox();
            cbTrem = new CheckBox();
            txtTransporteResultado = new TextBox();
            gbTransporte.SuspendLayout();
            SuspendLayout();
            // 
            // btnConfirmarTrasnporte
            // 
            btnConfirmarTrasnporte.Location = new Point(347, 405);
            btnConfirmarTrasnporte.Name = "btnConfirmarTrasnporte";
            btnConfirmarTrasnporte.Size = new Size(211, 51);
            btnConfirmarTrasnporte.TabIndex = 5;
            btnConfirmarTrasnporte.Text = "Confirmar";
            btnConfirmarTrasnporte.UseVisualStyleBackColor = true;
            btnConfirmarTrasnporte.Click += btnConfirmarTrasnporte_Click;
            // 
            // gbTransporte
            // 
            gbTransporte.Controls.Add(cbTrem);
            gbTransporte.Controls.Add(cbAviao);
            gbTransporte.Controls.Add(cbCarro);
            gbTransporte.Location = new Point(213, 145);
            gbTransporte.Name = "gbTransporte";
            gbTransporte.Size = new Size(365, 178);
            gbTransporte.TabIndex = 4;
            gbTransporte.TabStop = false;
            gbTransporte.Text = "Transportes";
            // 
            // lblTransporte
            // 
            lblTransporte.AutoSize = true;
            lblTransporte.Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            lblTransporte.Location = new Point(12, 41);
            lblTransporte.Name = "lblTransporte";
            lblTransporte.Size = new Size(851, 72);
            lblTransporte.TabIndex = 3;
            lblTransporte.Text = "Selecione os Meios de Transportes";
            // 
            // cbCarro
            // 
            cbCarro.AutoSize = true;
            cbCarro.Location = new Point(52, 39);
            cbCarro.Name = "cbCarro";
            cbCarro.Size = new Size(55, 19);
            cbCarro.TabIndex = 0;
            cbCarro.Text = "Carro";
            cbCarro.UseVisualStyleBackColor = true;
            // 
            // cbAviao
            // 
            cbAviao.AutoSize = true;
            cbAviao.Location = new Point(52, 76);
            cbAviao.Name = "cbAviao";
            cbAviao.Size = new Size(56, 19);
            cbAviao.TabIndex = 1;
            cbAviao.Text = "Avião";
            cbAviao.UseVisualStyleBackColor = true;
            // 
            // cbTrem
            // 
            cbTrem.AutoSize = true;
            cbTrem.Location = new Point(52, 114);
            cbTrem.Name = "cbTrem";
            cbTrem.Size = new Size(52, 19);
            cbTrem.TabIndex = 2;
            cbTrem.Text = "Trem";
            cbTrem.UseVisualStyleBackColor = true;
            // 
            // txtTransporteResultado
            // 
            txtTransporteResultado.Location = new Point(204, 352);
            txtTransporteResultado.Name = "txtTransporteResultado";
            txtTransporteResultado.Size = new Size(475, 23);
            txtTransporteResultado.TabIndex = 6;
            // 
            // FormTransporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 490);
            Controls.Add(txtTransporteResultado);
            Controls.Add(btnConfirmarTrasnporte);
            Controls.Add(gbTransporte);
            Controls.Add(lblTransporte);
            Name = "FormTransporte";
            Text = "Transporte";
            gbTransporte.ResumeLayout(false);
            gbTransporte.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirmarTrasnporte;
        private GroupBox gbTransporte;
        private CheckBox cbTrem;
        private CheckBox cbAviao;
        private CheckBox cbCarro;
        private Label lblTransporte;
        private TextBox txtTransporteResultado;
    }
}