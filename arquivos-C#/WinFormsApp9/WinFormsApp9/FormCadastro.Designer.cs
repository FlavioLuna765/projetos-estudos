namespace WinFormsApp9
{
    partial class FormCadastro
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
            btnSalvar = new Button();
            Nome = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            txtPreco = new TextBox();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(224, 318);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(399, 105);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "button1";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Location = new Point(138, 137);
            Nome.Name = "Nome";
            Nome.Size = new Size(40, 15);
            Nome.TabIndex = 1;
            Nome.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 218);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 2;
            label2.Text = "Preço";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(224, 137);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(399, 23);
            txtNome.TabIndex = 3;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(224, 215);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(399, 23);
            txtPreco.TabIndex = 4;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPreco);
            Controls.Add(txtNome);
            Controls.Add(label2);
            Controls.Add(Nome);
            Controls.Add(btnSalvar);
            Name = "FormCadastro";
            Text = "FormCadastro";
            Load += FormCadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar;
        private Label Nome;
        private Label label2;
        private TextBox txtNome;
        private TextBox txtPreco;
    }
}