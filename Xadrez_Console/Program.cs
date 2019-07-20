using System;
using tabuleiro;
using Xadrez;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Tabuleiro tab = new Tabuleiro(linhas: 8, colunas: 8);

                tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(1, 6));
                tab.ColocarPeca(new Rei(Cor.Preta, tab), new Posicao(0, 2));
                tab.ColocarPeca(new Rei(Cor.Branca, tab), new Posicao(7,3));


                Tela.ImprimirTab(tab);
            }
            catch (TabuleiroException ex){
                Console.WriteLine("Erro: " + ex.Message);
            }
            Console.ReadLine();
        }
    }
}
