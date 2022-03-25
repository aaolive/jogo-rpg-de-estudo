namespace jogo_rpg_de_estudo.Classes
{
    public abstract class Heroi : Personagem
    {
        // variáveis
        string profissao;
        Personagem personagemAlvo;

        // Propriedades
        public string Profissao { get => profissao; set => profissao = value; }
        public Personagem PersonagemAlvo { get => personagemAlvo; set => personagemAlvo = value; }

        // Métodos
        // faz o ataque e diminui vida do oponente
        public virtual void Atacar(Heroi heroiParaAtacar){
            
        }

        // método para realizar defesa do heroi.
        public virtual void DefenderAtaque(){
            
        }
        
    }
}