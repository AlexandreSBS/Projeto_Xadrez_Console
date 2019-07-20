using System;
using tabuleiro;
using Xadrez;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('a', 1);

            

            Console.WriteLine(pos.ToPosicao());
            Console.ReadLine();
        }
    }
}
