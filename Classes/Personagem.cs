namespace jogo_rpg_de_estudo.Classes
{
    public abstract class Personagem
    {
        // atributos
        string nome;
        int pontosDeVida;
        int pontosDeMagia;
        int nivelDoPersonagem;

        public string Nome { get => nome; set => nome = value; }
        public int PontosDeVida { get => pontosDeVida; set => pontosDeVida = value; }
        public int NivelDoPersonagem { get => nivelDoPersonagem; set => nivelDoPersonagem = value; }
        public int PontosDeMagia { get => pontosDeMagia; set => pontosDeMagia = value; }

        // Classe para definir a habilidade do personagem.
        public abstract class Habilidade
        {
            // atributos
            string nome;
            string descricao;

            public string Nome { get => nome; set => nome = value; }
            public string Descricao { get => descricao; set => descricao = value; }

            // Métodos
            public virtual void Usar(){
                
            }
        }
    }
}