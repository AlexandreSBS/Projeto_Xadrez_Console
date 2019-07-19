using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public  Cor cor { get; protected set; }
        public int quantMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }


        public Peca (Cor cor, Posicao posicao, Tabuleiro tab, int quantMovimentos)
        {
            this.cor = cor;
            this.posicao = posicao;
            this.tab = tab;
            this.quantMovimentos = 0;
        }
    }
}
