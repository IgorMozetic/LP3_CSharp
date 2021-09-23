using System;
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
            this.Caracteristicas();
        }
        protected override void Caracteristicas()
        {
            Console.Write("Pele: cabelos e pelos, Ambiente: quente e frio.\n\n");
        }
    }
}
