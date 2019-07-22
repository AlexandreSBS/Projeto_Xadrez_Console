using System;
using tabuleiro;
using Xadrez;

namespace Xadrez_Console {
    class Program {
        static void Main(string[] args) {
            try {
                PartidaDeXadrez partida = new PartidaDeXadrez();
                while (!partida.Terminada) {
                    try {
                        Console.Clear();
                        Tela.ImprimirPartida(partida);

                        Console.WriteLine();
                        Console.Write("Origem: ");
                        Posicao origem = Tela.LerPosicaoXadrez().ToPosicao();
                        partida.ValidarPosicaoDeOrigem(origem);

                        bool[,] possicoesPossiveis = partida.Tab.Peca(origem).MovimentosPossiveis();

                        Console.Clear();
                        Tela.ImprimirTab(partida.Tab, possicoesPossiveis);

                        Console.WriteLine();
                        Console.Write("Destino: ");
                        Posicao destino = Tela.LerPosicaoXadrez().ToPosicao();
                        partida.ValidarPosicaoDeDestino(origem, destino);

                        partida.RealizaJogada(origem, destino);
                    }
                    catch (TabuleiroException ex) {
                        Console.WriteLine(ex.Message);
                        Console.ReadKey();
                    }
                    catch (Exception ex) {
                        Console.WriteLine(ex.Message);
                        Console.ReadKey();
                    }
                }
            }
            catch (TabuleiroException ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
