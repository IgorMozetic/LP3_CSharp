using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_aula8
{
    class Teste
    {
        public static void Main(string[] args)
        {
            Casa c1 = new Casa();
            c1.Area = 150.5F;
            c1.Altura = 3.5F;
            c1.preco = 100000000;
            Console.Write("A área da casa é: " + c1.Area + "m\nA Altura da casa é: " + c1.Altura + "m\nO preço da casa é: R$ " + c1.preco);
        }
    }
}
