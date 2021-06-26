using System;
					
public class Notas2
{
	public static void Main()
	{
		double n1, n2, n3, media=0.0;
		Console.Write("Entre com a nota do Trabalho de Laboratório: ");
		n1 = double.Parse(Console.ReadLine());
		Console.Write("Entre com a nota da Avaliação Semestral: ");
		n2 = double.Parse(Console.ReadLine());
		Console.Write("Entre com a nota do Exame Final: ");
		n3 = double.Parse(Console.ReadLine());
		
		if ( (n1 > 0 && n1 < 10) && (n2 > 0 && n2 < 10) && (n3 > 0 && n3 < 10)  )
			media = ((n1*2) + (n2*3) + (n3*5))/10;
			Console.Write("A média ponderada entre as notas é de: " + media);
		
		if ( media >= 0 && media <= 2.9)
			Console.Write("\nO aluno está reprovado");
		else if ( media >= 3 && media <= 4.9)
			Console.Write("\nO aluno está de recuperação");
		else
			Console.Write("\nO aluno está aprovado");
	}
}
