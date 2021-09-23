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
           this.Caracteristicas();
        }
        protected override void Caracteristicas()
        {
            Console.Write("Pele: pelos, Ambiente: doméstico, ruas, parques.\n\n");
        }
    }
}
