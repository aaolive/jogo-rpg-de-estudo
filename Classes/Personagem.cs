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
        public int PontosDeMagia { get => pontosDeMagia; set => pontosDeMagia = value; }
        public int NivelDoPersonagem { get => nivelDoPersonagem; set => nivelDoPersonagem = value; }
        

        // Classe para definir a habilidade do personagem.
        public abstract class Habilidade
        {
            // atributos
            string nome;
            string descricao;
            Personagem personagem;
            
            // propriedades
            public string Nome { get => nome; set => nome = value; }
            public string Descricao { get => descricao; set => descricao = value; }
            public virtual Personagem Personagem { get => personagem; set => personagem = value; }

            // Métodos
            public virtual void Usar()
            {

            }
        }
    }
}