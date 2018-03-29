﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtdeMovimento { get; protected set; }
        public Tabuleiro tab {get;protected set;}

        public Peca(Posicao posicao, Tabuleiro tab, Cor cor)
        {
            this.tab = tab;
            this.posicao = posicao;
            this.cor = cor;
            this.qtdeMovimento = 0;
        }
    }
}
