using System;
					
public class Aposentadoria
{
	public static void Main()
	{
		int idade, tempo;
		Console.WriteLine("Entre com a sua idade:");
		idade = int.Parse(Console.ReadLine());
		Console.WriteLine("Entre com o seu tempo de serviço:");
		tempo =  int.Parse(Console.ReadLine());

		if( (idade >= 65) || (tempo >= 30) || ((tempo>=25) && (idade>=60)) )
			Console.WriteLine("Aposentadoria concedida");
		else
			Console.WriteLine("Aposentadoria Negada");
	}
}
