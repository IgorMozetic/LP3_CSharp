using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_aula11
{
    class Cachorro : Mamifero
    {
        public Cachorro()
        {
            this.exibirCaracterísticas();
        }
        protected override void exibirCaracterísticas()
        {
            base.exibirCaracterísticas();
            Console.Write("Cachorro -> Pele: pelos, Ambiente: doméstico, ruas, parques.\n\n");
        }
    }
}
