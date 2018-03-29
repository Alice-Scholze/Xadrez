using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            tabuleiro.Tabuleiro tab = new tabuleiro.Tabuleiro(8,8);
            Tela.imprimirTabuleiro(tab);            
            
            
            Console.ReadLine();

        }
    }
}
