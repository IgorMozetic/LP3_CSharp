using System;
					
public class Comparacao
{
	public static void Main()
	{

	int var1 = 5, var2=2;
		
		if( var1 == var2 )
			Console.WriteLine("Os operadores são iguais.");
		else
			Console.WriteLine("Os operaadores são diferentes.");
		
		if ( var1 != var2 )
			Console.WriteLine("Os operandos são diferentes.");
		else
			Console.WriteLine("Os operadores são iguais.");
		
		if( var1 > var2 )
			Console.WriteLine(" O 1º operando é maior que o 2º operando.");
		else
			Console.WriteLine("O 1º é menor ou igual que o 2º operando.");
	}
}
