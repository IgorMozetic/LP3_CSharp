using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_aula11
{
    class Sapo : Anfibio
    {
        public Sapo()
        {
            this.exibirCaracterísticas();
        }
        protected override void exibirCaracterísticas()
        {
            Console.Write("Pele: seca, glandular e vascularizada, Ambiente: riachos, lagoas, igarapés e brejos.\n\n");
        }
    }
}
