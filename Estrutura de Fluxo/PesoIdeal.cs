using System;
					
public class PesoIdeal
{
	public static void Main()
	{
		
		double genero, altura;
		Console.WriteLine("Entre com o seu genero (1 para HOMENS e 2 para MULHERES): ");
		genero = double.Parse(Console.ReadLine());
		Console.WriteLine("Entre com o seu peso: ");
		altura = double.Parse(Console.ReadLine());
		
		if ( genero == 1)
			Console.WriteLine("O seu peso ideal é de: " + ((72.7 * altura) - 58.0));
	 	else
			Console.WriteLine("O seu peso ideal é de: " + ((62.1 * altura) - 44.7));	
	}
}
