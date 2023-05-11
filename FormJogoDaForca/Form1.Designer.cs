namespace FormJogoDaForca
{
    partial class TelaFormJogoDaForca
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
            panel1 = new Panel();
            txtBoneco = new RichTextBox();
            panel2 = new Panel();
            lbForca = new Label();
            txtMensagem = new TextBox();
            panel3 = new Panel();
            txtLetra = new TextBox();
            btnPalpite = new Button();
            btnResetar = new Button();
            lbPalavra = new Label();
            txtPalavra = new TextBox();
            lbTentativas = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtBoneco);
            panel1.Location = new Point(30, 118);
            panel1.Name = "panel1";
            panel1.Size = new Size(274, 213);
            panel1.TabIndex = 0;
            // 
            // txtBoneco
            // 
            txtBoneco.BackColor = SystemColors.Info;
            txtBoneco.Enabled = false;
            txtBoneco.Location = new Point(0, 3);
            txtBoneco.Name = "txtBoneco";
            txtBoneco.Size = new Size(272, 210);
            txtBoneco.TabIndex = 0;
            txtBoneco.Text = "";
            // 
            // panel2
            // 
            panel2.Controls.Add(lbForca);
            panel2.Controls.Add(txtMensagem);
            panel2.Location = new Point(30, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(583, 61);
            panel2.TabIndex = 1;
            // 
            // lbForca
            // 
            lbForca.AutoSize = true;
            lbForca.Location = new Point(234, 0);
            lbForca.Name = "lbForca";
            lbForca.Size = new Size(93, 15);
            lbForca.TabIndex = 3;
            lbForca.Text = "Adivinhe a Fruta";
            // 
            // txtMensagem
            // 
            txtMensagem.BackColor = SystemColors.Info;
            txtMensagem.Dock = DockStyle.Bottom;
            txtMensagem.Enabled = false;
            txtMensagem.Location = new Point(0, 38);
            txtMensagem.Name = "txtMensagem";
            txtMensagem.Size = new Size(583, 23);
            txtMensagem.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtLetra);
            panel3.Controls.Add(btnPalpite);
            panel3.Location = new Point(414, 206);
            panel3.Name = "panel3";
            panel3.Size = new Size(102, 68);
            panel3.TabIndex = 1;
            // 
            // txtLetra
            // 
            txtLetra.Dock = DockStyle.Top;
            txtLetra.Location = new Point(0, 0);
            txtLetra.Name = "txtLetra";
            txtLetra.Size = new Size(102, 23);
            txtLetra.TabIndex = 2;
            txtLetra.TextChanged += textBox1_TextChanged;
            // 
            // btnPalpite
            // 
            btnPalpite.Dock = DockStyle.Bottom;
            btnPalpite.Location = new Point(0, 45);
            btnPalpite.Name = "btnPalpite";
            btnPalpite.Size = new Size(102, 23);
            btnPalpite.TabIndex = 0;
            btnPalpite.Text = "Palpite";
            btnPalpite.UseVisualStyleBackColor = true;
            btnPalpite.Click += btnPalpite_Click;
            // 
            // btnResetar
            // 
            btnResetar.Location = new Point(414, 308);
            btnResetar.Name = "btnResetar";
            btnResetar.Size = new Size(102, 23);
            btnResetar.TabIndex = 1;
            btnResetar.Text = "Resetar";
            btnResetar.UseVisualStyleBackColor = true;
            btnResetar.Click += btnResetar_Click;
            // 
            // lbPalavra
            // 
            lbPalavra.AutoSize = true;
            lbPalavra.Location = new Point(442, 87);
            lbPalavra.Name = "lbPalavra";
            lbPalavra.Size = new Size(45, 15);
            lbPalavra.TabIndex = 2;
            lbPalavra.Text = "Palavra";
            // 
            // txtPalavra
            // 
            txtPalavra.BackColor = SystemColors.Info;
            txtPalavra.Enabled = false;
            txtPalavra.Location = new Point(374, 121);
            txtPalavra.Name = "txtPalavra";
            txtPalavra.Size = new Size(176, 23);
            txtPalavra.TabIndex = 3;
            // 
            // lbTentativas
            // 
            lbTentativas.AutoSize = true;
            lbTentativas.Location = new Point(70, 87);
            lbTentativas.Name = "lbTentativas";
            lbTentativas.Size = new Size(59, 15);
            lbTentativas.TabIndex = 4;
            lbTentativas.Text = "Tentativas";
            // 
            // TelaFormJogoDaForca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(625, 360);
            Controls.Add(lbTentativas);
            Controls.Add(txtPalavra);
            Controls.Add(btnResetar);
            Controls.Add(lbPalavra);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            MaximizeBox = false;
            MaximumSize = new Size(641, 399);
            MinimizeBox = false;
            MinimumSize = new Size(641, 399);
            Name = "TelaFormJogoDaForca";
            Text = "JogoDaForca";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private RichTextBox txtBoneco;
        private Label lbForca;
        private TextBox txtLetra;
        private Button btnResetar;
        private Button btnPalpite;
        private TextBox txtMensagem;
        private Label lbPalavra;
        private TextBox txtPalavra;
        private Label lbTentativas;
    }
}