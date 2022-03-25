using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jogo_rpg_de_estudo.Classes
{
    public class Mago : Heroi
    {
        // construtor
        public Mago()
        {
            this.Nome = "Rose";
            this.PontosDeVida = 90;
            this.PontosDeMagia = 110;
        }

        // classes de habilidade do mago
        class MagiaDeVeneno : Habilidade
        {

            // variaveis
            short dano = 10;

            public MagiaDeVeneno()
            {
                this.Nome = "Magia venenosa";
                this.Descricao = "Causa dano venenoso ao alvo.";
            }

            public override void Usar(Personagem personagemAlvo)
            {
                this.Personagem = personagemAlvo;
                this.Personagem.PontosDeVida -= dano;
            }
        }

        // Metodos
        public void UsarHabilidadeMagiaDeVeneno(Personagem personagem)
        {
            MagiaDeVeneno magiaDeVeneno = new MagiaDeVeneno();
            magiaDeVeneno.Usar(personagem);
        }
    }
}