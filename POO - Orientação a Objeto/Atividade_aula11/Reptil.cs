using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_aula11
{
    class Reptil : Animal
    {
        public Reptil()
        {
            this.exibirCaracterísticas();
        }
        protected override void exibirCaracterísticas()
        {
            Console.Write("Pele: escamas, Ambiente: quente.\n\n");
        }

    }
}
