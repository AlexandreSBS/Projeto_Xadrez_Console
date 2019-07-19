using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public Tabuleiro Tab { get; protected set; }
        public int QuantMovimentos { get; protected set; }

        public Peca(Cor cor, Posicao posicao, Tabuleiro tab, int quantMovimentos)
        {
            Cor = cor;
            Posicao = posicao;
            Tab = tab;
            QuantMovimentos = 0;
        }
    }
}
