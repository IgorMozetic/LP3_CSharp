using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_aula11
{
    class Jacare : Reptil
    {
        public Jacare()
        {
            this.exibirCaracterísticas();
        }
        protected override void exibirCaracterísticas()
        {
            Console.Write("Pele: placas muito duras, como serrilhado, Ambiente: rios, lagos e pântanos.\n\n");
        }
    }
}
