using System;

public class SomaInteiro
{
	public static void Main()
	{
		int n1, n2, n3, soma;
		Console.WriteLine("Entre com o primeiro número:");
		n1 = int.Parse(Console.ReadLine());
		n2 = int.Parse(Console.ReadLine());
		n3 = int.Parse(Console.ReadLine());
		soma = n1 + n2 + n3;
		
		Console.WriteLine("A soma dos numeros é igual a :" +soma);
	}
}
