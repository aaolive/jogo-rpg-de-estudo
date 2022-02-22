namespace jogo_rpg_de_estudo.Classes
{
    public class Personagem
    {
        string nome;
        int pontosDeVida;
        int nivelDoPersonagem;

        public string Nome { get => nome; set => nome = value; }
        public int PontosDeVida { get => pontosDeVida; set => pontosDeVida = value; }
        public int NivelDoPersonagem { get => nivelDoPersonagem; set => nivelDoPersonagem = value; }
    }
}