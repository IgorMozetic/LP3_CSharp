using System;
					
public class ParImpar
{
	public static void Main()
	{
		int num;
		Console.Write("Entre com um número inteiro: ");
		num = int.Parse(Console.ReadLine());
		
		if ( num % 2 == 0 ) 
			Console.WriteLine("O número inserido é par" );
		else
			Console.WriteLine("O número inserido é ímpar" );
	}
}
