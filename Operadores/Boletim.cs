using System;
					
public class Boletim
{
	public static void Main()
	{
		int media = 7, presenca = 80;
		string nota = "ótimo", situacao = "reprovado";
		
		if(( media >= 6 ) && ( presenca >= 75 ))
			Console.WriteLine("O aluno foi aprovado.");
		else
			Console.WriteLine("O aluno foi reprovado.");
		
		if(( nota == "ótimo" ) || ( nota == "bom" ))
			Console.WriteLine("O aluno foi aprovado.");
		else
			Console.WriteLine("O aluno foi reprovado.");
		
		
		if ( !(situacao == "aprovado") )
			Console.WriteLine("O aluno foi reprovado.");
		else
			Console.WriteLine("O aluno foi aprovado.");
		
	}
}
