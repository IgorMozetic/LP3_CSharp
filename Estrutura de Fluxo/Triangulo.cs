using System;				
public class Triangulo{
	public static void Main()
	{
		int lado1, lado2, lado3;		
		Console.WriteLine("Entre com o primeiro lado:");
		lado1 = int.Parse(Console.ReadLine());
		Console.WriteLine("Entre com o segundo lado:");
		lado2 = int.Parse(Console.ReadLine());
		Console.WriteLine("Entre com o terceiro lado:");
		lado3 = int.Parse(Console.ReadLine());	
	if  (!(lado1 + lado2 > lado3) && (lado1 + lado3 > lado2) && (lado2 + lado3 > lado1) )
        Console.WriteLine("Os dados inseridos não formam um triângulo!");
	else if( lado1 == lado2 && lado1 == lado3 )
            Console.WriteLine("Triângulo Equilátero");
        else if( lado1 == lado2 || lado1 == lado3 || lado2 == lado3 )
                Console.WriteLine(" Triângulo Isósceles");
            else 
                Console.WriteLine(" Triângulo Escaleno");
	}
}
