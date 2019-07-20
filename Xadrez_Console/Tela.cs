using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace Xadrez_Console {
    class Tela {

        public static void ImprimirTab(Tabuleiro tab) {
            for (int i = 0; i < tab.Linhas; i++) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(8 - i + " ");
                Console.ForegroundColor = ConsoleColor.White;
                for (int j = 0; j < tab.Colunas; j++) {
                    if (tab.Peca(i, j) == null) {
                        Console.Write("- ");
                    }
                    else {
                        ImprimirPeca(tab.Peca(i, j));
                        Console.Write(" ");

                    }
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  a b c d e f g h");

        }
        public static void ImprimirPeca(Peca peca) {
            if(peca.Cor == Cor.Branca) {
                Console.Write(peca);
            }
            else {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca );
                Console.ForegroundColor = aux;
            }
        }
    }
}
