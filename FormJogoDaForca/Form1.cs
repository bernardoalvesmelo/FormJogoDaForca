namespace FormJogoDaForca
{
    public partial class TelaFormJogoDaForca : Form
    {
        private JogoDaForca jogoDaForca;
        public TelaFormJogoDaForca()
        {
            InitializeComponent();
            this.jogoDaForca = new JogoDaForca();
            this.txtBoneco.Text = jogoDaForca.DesenharForca();
            Resetar();
            AtualizarValores();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtLetra.Text == "")
            {
                return;
            }
            txtLetra.Text = "" + txtLetra.Text[0];
        }

        private void btnPalpite_Click(object sender, EventArgs e)
        {
            this.jogoDaForca.ReceberTentativa(txtLetra.Text);
            this.txtLetra.Text = "";
            AtualizarValores();
            string resultado = this.jogoDaForca.ObterResultado();
            VerificarResultado(resultado);
            this.txtBoneco.Text = jogoDaForca.DesenharForca();
        }

        private void AtualizarValores()
        {
            this.lbTentativas.Text = "Tentativas: " + this.jogoDaForca.ObterTentativas();
            this.txtPalavra.Text = this.jogoDaForca.ObterLetrasDescobertas();
        }

        private void VerificarResultado(string resultado)
        {
            if (resultado == "")
            {
                return;
            }
            this.txtMensagem.Text = resultado;
            this.btnPalpite.Enabled = false;
        }

        private void Resetar()
        {
            this.txtMensagem.Text = "Digite uma letra";
            this.jogoDaForca.IniciarValores();
            this.btnPalpite.Enabled = true;
        }

        private void btnResetar_Click(object sender, EventArgs e)
        {
            Resetar();
            AtualizarValores();
            this.txtBoneco.Text = jogoDaForca.DesenharForca();
        }
    }
}