﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_aula11
{
    class Mamifero : Animal
    {
        public Mamifero()
        {
            this.exibirCaracterísticas();
        }
        protected override void exibirCaracterísticas()
        {
            base.exibirCaracterísticas();
            Console.Write(" dos mamíferos\n");
            Console.Write("Pele: cabelos e pelos, Ambiente: quente e frio.\n");
        }
    }
}
