using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_aula11
{
    class Gato : Mamifero
    {
        public Gato()
        {
           this.exibirCaracterísticas();
        }
        protected override void exibirCaracterísticas()
        {
            Console.Write("Pele: pelos, Ambiente: doméstico, ruas, parques.\n\n");
        }
    }
}
