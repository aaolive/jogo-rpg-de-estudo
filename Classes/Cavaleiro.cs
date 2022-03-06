using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jogo_rpg_de_estudo.Classes
{
    public class Cavaleiro : Heroi
    {

        // classe de habilidade
        public class HabilidadeDeCura : Habilidade
        {
            private Cavaleiro cavaleiro;

                HabilidadeDeCura()
            {
                Nome = "Cura do cavaleiro";
                Descricao = "Cura a vida o cavaleiro em 20";
            }

            public HabilidadeDeCura(Cavaleiro cavaleiro)
            {
                this.cavaleiro = cavaleiro;
                this.cavaleiro.PontosDeVida += 20;              

            }

            public override void UsarHabilidade()
            {
                
            }
        }
        
    }
}