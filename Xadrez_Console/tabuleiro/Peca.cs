using System;
using System.Collections.Generic;
using System.Text;
using Xadrez;

namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public Tabuleiro Tab { get; protected set; }
        public int QuantMovimentos { get; protected set; }

        public Peca(Cor cor, Tabuleiro tab)
        {
            Cor = cor;
            Posicao = null;
            Tab = tab;
            QuantMovimentos = 0;
        }

        public void IncrementarQuantMovimentos() {
            QuantMovimentos++;
        }
        public abstract bool[,] MovimentosPossiveis(); 
        
    }
}
