namespace WinFormsApp5
{
    partial class FormMain
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
            btnDestino = new Button();
            btnTransporte = new Button();
            btnInformacoes = new Button();
            btnCalculoDesconto = new Button();
            SuspendLayout();
            // 
            // btnDestino
            // 
            btnDestino.Location = new Point(309, 31);
            btnDestino.Name = "btnDestino";
            btnDestino.Size = new Size(169, 61);
            btnDestino.TabIndex = 0;
            btnDestino.Text = "Destino";
            btnDestino.UseVisualStyleBackColor = true;
            btnDestino.Click += btnDestino_Click;
            // 
            // btnTransporte
            // 
            btnTransporte.Location = new Point(309, 128);
            btnTransporte.Name = "btnTransporte";
            btnTransporte.Size = new Size(169, 61);
            btnTransporte.TabIndex = 1;
            btnTransporte.Text = "Transporte";
            btnTransporte.UseVisualStyleBackColor = true;
            btnTransporte.Click += btnTransporte_Click;
            // 
            // btnInformacoes
            // 
            btnInformacoes.Location = new Point(309, 229);
            btnInformacoes.Name = "btnInformacoes";
            btnInformacoes.Size = new Size(169, 61);
            btnInformacoes.TabIndex = 2;
            btnInformacoes.Text = "Informacoes";
            btnInformacoes.UseVisualStyleBackColor = true;
            btnInformacoes.Click += btnInformacoes_Click;
            // 
            // btnCalculoDesconto
            // 
            btnCalculoDesconto.Location = new Point(309, 326);
            btnCalculoDesconto.Name = "btnCalculoDesconto";
            btnCalculoDesconto.Size = new Size(169, 61);
            btnCalculoDesconto.TabIndex = 3;
            btnCalculoDesconto.Text = "CalculoDesconto";
            btnCalculoDesconto.UseVisualStyleBackColor = true;
            btnCalculoDesconto.Click += btnCalculoDesconto_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCalculoDesconto);
            Controls.Add(btnInformacoes);
            Controls.Add(btnTransporte);
            Controls.Add(btnDestino);
            Name = "FormMain";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDestino;
        private Button btnTransporte;
        private Button btnInformacoes;
        private Button btnCalculoDesconto;
    }
}