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

        class MagiaDeVeneno : Habilidade
        {
            public MagiaDeVeneno()
            {
                this.Nome = "Magia venenosa";
            }
        }
    }
}