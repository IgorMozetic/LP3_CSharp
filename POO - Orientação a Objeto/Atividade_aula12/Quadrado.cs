using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_aula12
{
    class Quadrado : Forma 
    {
        private double lado;

        public Quadrado(double lado)
        {
            base.setCor("Azul");
            this.lado = lado;
            Console.WriteLine("Área do Quadrado: " + this.calculcarArea() + "\n");
        }

        public Quadrado(string cor, double lado)
        {
            base.setCor(cor);
            this.lado = lado;
            Console.WriteLine("Área do Quadrado: " + this.calculcarArea() + "\n");
        }
        public override double calculcarArea()
        {
            return lado * lado;
        }
    }
}
