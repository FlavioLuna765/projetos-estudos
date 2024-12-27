namespace WinFormsApp4
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
            cmbSabor = new ComboBox();
            grpTamanho = new GroupBox();
            rbGrande = new RadioButton();
            rbMedia = new RadioButton();
            rbPequena = new RadioButton();
            grpPagamento = new GroupBox();
            rbCartao = new RadioButton();
            rbDinheiro = new RadioButton();
            btnConfirmar = new Button();
            grpAdicionais = new GroupBox();
            chkBacon = new CheckBox();
            chkBorda = new CheckBox();
            chkQueijo = new CheckBox();
            grpTamanho.SuspendLayout();
            grpPagamento.SuspendLayout();
            grpAdicionais.SuspendLayout();
            SuspendLayout();
            // 
            // cmbSabor
            // 
            cmbSabor.FormattingEnabled = true;
            cmbSabor.Items.AddRange(new object[] { "Calabresa", "Quatro Queijos", "Portuguesa" });
            cmbSabor.Location = new Point(342, 265);
            cmbSabor.Name = "cmbSabor";
            cmbSabor.Size = new Size(121, 23);
            cmbSabor.TabIndex = 0;
            cmbSabor.Text = "Sabor";
            // 
            // grpTamanho
            // 
            grpTamanho.Controls.Add(rbGrande);
            grpTamanho.Controls.Add(rbMedia);
            grpTamanho.Controls.Add(rbPequena);
            grpTamanho.Location = new Point(65, 38);
            grpTamanho.Name = "grpTamanho";
            grpTamanho.Size = new Size(200, 158);
            grpTamanho.TabIndex = 1;
            grpTamanho.TabStop = false;
            grpTamanho.Text = "Tamanho";
            // 
            // rbGrande
            // 
            rbGrande.AutoSize = true;
            rbGrande.Location = new Point(21, 81);
            rbGrande.Name = "rbGrande";
            rbGrande.Size = new Size(63, 19);
            rbGrande.TabIndex = 2;
            rbGrande.TabStop = true;
            rbGrande.Text = "Grande";
            rbGrande.UseVisualStyleBackColor = true;
            // 
            // rbMedia
            // 
            rbMedia.AutoSize = true;
            rbMedia.Location = new Point(21, 56);
            rbMedia.Name = "rbMedia";
            rbMedia.Size = new Size(58, 19);
            rbMedia.TabIndex = 1;
            rbMedia.TabStop = true;
            rbMedia.Text = "Média";
            rbMedia.UseVisualStyleBackColor = true;
            // 
            // rbPequena
            // 
            rbPequena.AutoSize = true;
            rbPequena.Location = new Point(21, 31);
            rbPequena.Name = "rbPequena";
            rbPequena.Size = new Size(71, 19);
            rbPequena.TabIndex = 0;
            rbPequena.TabStop = true;
            rbPequena.Text = "Pequena";
            rbPequena.UseVisualStyleBackColor = true;
            // 
            // grpPagamento
            // 
            grpPagamento.Controls.Add(rbCartao);
            grpPagamento.Controls.Add(rbDinheiro);
            grpPagamento.Location = new Point(65, 222);
            grpPagamento.Name = "grpPagamento";
            grpPagamento.Size = new Size(200, 100);
            grpPagamento.TabIndex = 2;
            grpPagamento.TabStop = false;
            grpPagamento.Text = "Forma de pagamento";
            // 
            // rbCartao
            // 
            rbCartao.AutoSize = true;
            rbCartao.Location = new Point(34, 47);
            rbCartao.Name = "rbCartao";
            rbCartao.Size = new Size(60, 19);
            rbCartao.TabIndex = 1;
            rbCartao.TabStop = true;
            rbCartao.Text = "Cartão";
            rbCartao.UseVisualStyleBackColor = true;
            // 
            // rbDinheiro
            // 
            rbDinheiro.AutoSize = true;
            rbDinheiro.Location = new Point(34, 22);
            rbDinheiro.Name = "rbDinheiro";
            rbDinheiro.Size = new Size(70, 19);
            rbDinheiro.TabIndex = 0;
            rbDinheiro.TabStop = true;
            rbDinheiro.Text = "Dinheiro";
            rbDinheiro.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(190, 363);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(216, 55);
            btnConfirmar.TabIndex = 3;
            btnConfirmar.Text = "Confimar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // grpAdicionais
            // 
            grpAdicionais.Controls.Add(chkBacon);
            grpAdicionais.Controls.Add(chkBorda);
            grpAdicionais.Controls.Add(chkQueijo);
            grpAdicionais.Location = new Point(342, 38);
            grpAdicionais.Name = "grpAdicionais";
            grpAdicionais.Size = new Size(170, 158);
            grpAdicionais.TabIndex = 4;
            grpAdicionais.TabStop = false;
            grpAdicionais.Text = "Adicionais";
            // 
            // chkBacon
            // 
            chkBacon.AutoSize = true;
            chkBacon.Location = new Point(38, 108);
            chkBacon.Name = "chkBacon";
            chkBacon.Size = new Size(59, 19);
            chkBacon.TabIndex = 2;
            chkBacon.Text = "Bacon";
            chkBacon.UseVisualStyleBackColor = true;
            // 
            // chkBorda
            // 
            chkBorda.AutoSize = true;
            chkBorda.Location = new Point(38, 68);
            chkBorda.Name = "chkBorda";
            chkBorda.Size = new Size(57, 19);
            chkBorda.TabIndex = 1;
            chkBorda.Text = "Borda";
            chkBorda.UseVisualStyleBackColor = true;
            // 
            // chkQueijo
            // 
            chkQueijo.AutoSize = true;
            chkQueijo.Location = new Point(38, 32);
            chkQueijo.Name = "chkQueijo";
            chkQueijo.Size = new Size(61, 19);
            chkQueijo.TabIndex = 0;
            chkQueijo.Text = "Queijo";
            chkQueijo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 450);
            Controls.Add(grpAdicionais);
            Controls.Add(btnConfirmar);
            Controls.Add(grpPagamento);
            Controls.Add(grpTamanho);
            Controls.Add(cmbSabor);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grpTamanho.ResumeLayout(false);
            grpTamanho.PerformLayout();
            grpPagamento.ResumeLayout(false);
            grpPagamento.PerformLayout();
            grpAdicionais.ResumeLayout(false);
            grpAdicionais.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbSabor;
        private GroupBox grpTamanho;
        private RadioButton rbMedia;
        private RadioButton rbPequena;
        private GroupBox grpPagamento;
        private RadioButton rbCartao;
        private RadioButton rbDinheiro;
        private Button btnConfirmar;
        private GroupBox grpAdicionais;
        private CheckBox chkBacon;
        private CheckBox chkBorda;
        private CheckBox chkQueijo;
        private RadioButton rbGrande;
    }
}