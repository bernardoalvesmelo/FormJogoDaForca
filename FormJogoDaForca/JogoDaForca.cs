namespace FormJogoDaForca
{
    public class JogoDaForca
    {
        private string[] palavras;
        private char[] palavraSecreta;
        private char[] letrasDescobertas;
        private int tentativas;

        public JogoDaForca()
        {
            IniciarValores();
        }
        public void IniciarValores()
        {
            this.palavras = CriarArrayPalavras();
            Random aleatorio = new Random();
            this.palavraSecreta = FormatarPalavra(palavras[aleatorio.Next(0, palavras.Length)]).ToCharArray();
            this.letrasDescobertas = new String('_', palavraSecreta.Length).ToCharArray();
            this.tentativas = 5;
        }

        public string ObterResultado()
        {
            if(tentativas == 0)
            {
                return "Você perdeu! A palavra era " + new string(this.palavraSecreta);
            }
            if (new string(palavraSecreta) == new string(letrasDescobertas))
            {
                return "Você venceu!";
            }
            return "";
        }

        public string ReceberTentativa(string letra)
        {
            letra = letra.ToUpper();
            if (VerificacaoLetra(letra))
            {
                return "Acertou a letra!";
            }
            else
            {
                tentativas--;
                return "Errou a letra!";
            }
        }
        public bool VerificacaoLetra(string letra)
        {
            bool ehCorreta = false;
            for (int i = 0; i < palavraSecreta.Length; i++)
            {
                if (letra[0] == palavraSecreta[i])
                {
                    ehCorreta = true;
                    letrasDescobertas[i] = letra[0];
                }
            }
            return ehCorreta;
        }

        public string[] CriarArrayPalavras()
        {
            return ("ABACATE,ABACAXI,ACEROLA,AÇAÍ,ARAÇA,ABACATE,BACABA,BACURI,BANANA,CAJÁ," +
                "CAJÚ,CARAMBOLA,CUPUAÇU,GRAVIOLA,GOIABA,JABUTICABA,JENIPAPO,MAÇÃ,MANGABA," +
                "MANGA,MARACUJÁ,MURICI,PEQUI,PITANGA,PITAYA,SAPOTI,TANGERINA,UMBU,UVA," +
                "UVAIA").Split(',');
        }

        public string FormatarPalavra(string palavra)
        {
            string acentos = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç";
            string formato = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc";

            for (int i = 0; i < acentos.Length; i++)
            {
                palavra = palavra.Replace(acentos[i] + "", formato[i] + "");
            }
            return palavra;
        }

        public int ObterTentativas()
        {
            return this.tentativas;
        }

        public string ObterLetrasDescobertas()
        {
            return new string(this.letrasDescobertas);
        }

        public string DesenharForca()
        {
            int quantidadeErros = 5 - tentativas;
            string cabecaDoBoneco = quantidadeErros >= 1 ? " o " : " ";
            string bracoEsquerdo = quantidadeErros >= 3 ? "/" : " ";
            string tronco = quantidadeErros >= 2 ? "x" : " ";
            string troncoBaixo = quantidadeErros >= 2 ? " x " : " ";
            string bracoDireito = quantidadeErros >= 3 ? @"\" : " ";
            string pernas = quantidadeErros >= 4 ? "/ \\" : " ";

            string boneco = "";

            boneco += ("\n ___________        ");
            boneco += ("\n |/        |        ");
            boneco += ($"\n |        {cabecaDoBoneco}       ");
            boneco += ($"\n |        {bracoEsquerdo}{tronco}{bracoDireito} ");
            boneco += ($"\n |        {troncoBaixo}       ");
            boneco += ($"\n |        {pernas}       ");
            boneco += ($"\n |                  ");
            boneco += ($"\n |                  ");
            boneco += ($"\n_|____              ");
            return boneco;
        }
    }
}