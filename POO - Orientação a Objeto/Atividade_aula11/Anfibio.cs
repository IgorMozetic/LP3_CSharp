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
            this.Caracteristicas();
        }
        protected override void Caracteristicas()
        {
            Console.Write("Pele: úmida, Ambiente: úmido e quente.\n\n");
        }
    }
}
