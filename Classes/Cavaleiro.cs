using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jogo_rpg_de_estudo.Classes
{
    public class Cavaleiro : Heroi
    {

        // contrutor
        public Cavaleiro()
        {
            this.Nome = "Hércules";
            this.PontosDeVida = 100;
            this.NivelDoPersonagem = 26;
        }

        // classe de habilidade de cavaleiro
        public class HabilidadeDeCura : Habilidade
        {
            
            // construtores
            public HabilidadeDeCura()
            {
                Nome = "Cura do cavaleiro";
                Descricao = "Cura a vida o cavaleiro em 20";
            }

            public HabilidadeDeCura(Personagem personagem)
            {
                this.Personagem = personagem;
                Nome = "Cura do cavaleiro";
                Descricao = "Cura a vida o cavaleiro em 20";
            }
            
            // métodos
            public override void Usar()
            {
                this.Personagem.PontosDeVida += 20;
            }
        }

        // Métodos
        public void UsarHabilidadeDeCura()
        {
            HabilidadeDeCura habilidadeDeCura = new HabilidadeDeCura(this);
            habilidadeDeCura.Usar();
        }

    }
}