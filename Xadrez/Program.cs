using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;
using xadrez;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            tabuleiro.Tabuleiro tab = new tabuleiro.Tabuleiro(8,8);
            tab.colocarPeca(new Torre (tab, Cor.Preto) , new Posicao(0,0));
            tab.colocarPeca(new Torre (tab, Cor.Preto) , new Posicao(1,2));
            tab.colocarPeca(new Rei (tab, Cor.Preto) , new Posicao(2,4));

            
            Tela.imprimirTabuleiro(tab);            
            
            
            Console.ReadLine();

        }
    }
}
