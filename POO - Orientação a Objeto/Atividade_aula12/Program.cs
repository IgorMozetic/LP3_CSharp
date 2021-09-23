using System;

namespace Atividade_aula12
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadrado quad1 = new Quadrado(5.0);
            Quadrado quad2 = new Quadrado("Laranja", 6.0);

            Retangulo retan1 = new Retangulo(10.0, 5.0);
            Retangulo retan2 = new Retangulo("Preto",10.0,6.0);

            Circulo circ1 = new Circulo(5.0);
            Circulo circ2 = new Circulo("Vermelho", 6.0);

            Triangulo tri1 = new Triangulo(10.0, 5.0);
            Triangulo tri2 = new Triangulo("Cinza", 10.0, 6.0);
        }
    }
}
