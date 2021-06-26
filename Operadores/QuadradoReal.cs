using System;
					
public class QuadradoReal
{
	public static void Main()
	{
		double num, quadrado;	
		Console.WriteLine("Entre com um numero real:");
		num = double.Parse(Console.ReadLine());
		quadrado = num*num;

            Console.WriteLine("O qudrado do numero inserido é: " + quadrado);
        
	}
}
