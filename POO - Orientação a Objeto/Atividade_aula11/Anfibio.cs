﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_aula11
{
    class Anfibio : Animal
    {
        public Anfibio()
        {
            this.exibirCaracterísticas();
        }
        protected override void exibirCaracterísticas()
        {
            base.exibirCaracterísticas();
            Console.Write(" dos anfíbios\n");
            Console.Write("Pele: úmida, Ambiente: úmido e quente.\n");
        }
    }
}
