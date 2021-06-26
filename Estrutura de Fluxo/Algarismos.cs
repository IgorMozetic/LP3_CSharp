using System;
					
public class Algarismos
{
	public static void Main()
	{
		int num, algarismo, soma = 0;
		Console.Write("Entre com um número inteiro positivo: ");
		num = int.Parse(Console.ReadLine());
		
		if ( num > 0 ) {
			
			while ( num > 0 ) {
				
				algarismo = num % 10;
				soma += algarismo;
				num = num / 10;
			}
			Console.Write("A soma dos algarismos é: " + soma );
		} else 
			Console.Write("Número inváldo");
	}
}
