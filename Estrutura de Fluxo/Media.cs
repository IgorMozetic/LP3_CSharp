using System;
					
public class Notas
{
	public static void Main()
	{
		double n1, n2, n3, media;
		Console.Write("Entre com as três notas: ");
		n1 = double.Parse(Console.ReadLine());
		n2 = double.Parse(Console.ReadLine());
		n3 = double.Parse(Console.ReadLine());
		
		media = (n1 + n2 + (n3*2))/4;
		
		if ( n1 > 0 && n2 > 0 && n3 > 0 )
			Console.Write("A média ponderada entre as notas é de: " + media);
		
		if (media > 6)
			Console.Write("\nO aluno está aprovado");
		else 
			Console.Write("\nO aluno está reprovado");
	}
}
