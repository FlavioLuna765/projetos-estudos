namespace WinFormsApp1
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
            btnAperteAqui = new Button();
            lblResultado = new Label();
            txtNome = new TextBox();
            txtValor1 = new TextBox();
            txtValor2 = new TextBox();
            lblSoma = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // btnAperteAqui
            // 
            btnAperteAqui.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnAperteAqui.Location = new Point(230, 318);
            btnAperteAqui.Name = "btnAperteAqui";
            btnAperteAqui.Size = new Size(374, 92);
            btnAperteAqui.TabIndex = 0;
            btnAperteAqui.Text = "Aperte aqui";
            btnAperteAqui.UseVisualStyleBackColor = true;
            btnAperteAqui.Click += btnAperteAqui_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 50F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.Location = new Point(136, 179);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(501, 89);
            lblResultado.TabIndex = 1;
            lblResultado.Text = "Aparecer Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(281, 117);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(242, 23);
            txtNome.TabIndex = 2;
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(836, 125);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(100, 23);
            txtValor1.TabIndex = 3;
            // 
            // txtValor2
            // 
            txtValor2.Location = new Point(836, 179);
            txtValor2.Name = "txtValor2";
            txtValor2.Size = new Size(100, 23);
            txtValor2.TabIndex = 4;
            // 
            // lblSoma
            // 
            lblSoma.AutoSize = true;
            lblSoma.Location = new Point(836, 221);
            lblSoma.Name = "lblSoma";
            lblSoma.Size = new Size(99, 15);
            lblSoma.TabIndex = 5;
            lblSoma.Text = "Soma dos valores";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(836, 261);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(100, 23);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 450);
            Controls.Add(btnCalcular);
            Controls.Add(lblSoma);
            Controls.Add(txtValor2);
            Controls.Add(txtValor1);
            Controls.Add(txtNome);
            Controls.Add(lblResultado);
            Controls.Add(btnAperteAqui);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAperteAqui;
        private Label lblResultado;
        private TextBox txtNome;
        private TextBox txtValor1;
        private TextBox txtValor2;
        private Label lblSoma;
        private Button btnCalcular;
    }
}