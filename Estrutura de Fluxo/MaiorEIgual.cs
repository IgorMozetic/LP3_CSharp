using System;
					
public class MaiorEIgual
{
	public static void Main()
	{
		double nota, nota2;
		Console.Write("Entre com dois número inteiros: ");
		nota = int.Parse(Console.ReadLine());
		nota2 = int.Parse(Console.ReadLine());
		
		if ( (nota >= 0 && nota <= 10) && (nota2 >= 0 && nota2 <= 10)  )
			Console.Write("A média entre as notas é: " + ((nota + nota2) / 2) );
		else 
			Console.WriteLine("Você inseriu nontas inválidas!");
	}
}
