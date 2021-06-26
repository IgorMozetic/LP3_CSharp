using System;
					
public class MaiorEDiferenca
{
	public static void Main()
	{
		int num, num2;
		Console.Write("Entre com dois número inteiros: ");
		num = int.Parse(Console.ReadLine());
		num2 = int.Parse(Console.ReadLine());
		
		if ( num > num2 )
			Console.Write("O número maior é: " + num + "\nA diferença entre eles é: " + ( num - num2 ) );
		else
			Console.Write("O número maior é: " + num2 + "\nA diferença entre eles é: " + ( num2 - num ) );
	}
}
