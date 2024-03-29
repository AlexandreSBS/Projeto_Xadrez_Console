﻿using System;
using System.Collections.Generic;
using System.Text;
using Xadrez;

namespace tabuleiro {
    abstract class Peca {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public Tabuleiro Tab { get; protected set; }
        public int QuantMovimentos { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor) {
            Cor = cor;
            Posicao = null;
            Tab = tab;
            QuantMovimentos = 0;
        }

        public void IncrementarQuantMovimentos() {
            QuantMovimentos++;
        }
        public void DecrementarQuantMovimentos() {
            QuantMovimentos--;
        }

        public bool ExisteMovimentosPossiveis() {
            bool[,] mat = MovimentosPossiveis();
            for (int i = 0; i < Tab.Linhas; i++) {
                for (int j = 0; j < Tab.Colunas; j++) {
                    if (mat[i, j]) {
                        return true;
                    }
                }

            }
            return false;
        }

        public bool MovimentoPossivel(Posicao pos) {
            return MovimentosPossiveis()[pos.Linha, pos.Coluna];
        }

        public abstract bool[,] MovimentosPossiveis();

    }
}
