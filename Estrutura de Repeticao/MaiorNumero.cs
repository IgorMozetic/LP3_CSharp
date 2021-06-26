using System;
					
public class MaiorNumero
{
	public static void Main()
	{
		int num, num2;
		Console.Write("Entre com dois número inteiros: ");
		num = int.Parse(Console.ReadLine());
		num2 = int.Parse(Console.ReadLine());
		
		if ( num > num2 )
			Console.Write("O número maior é: " + num );
		else
			Console.Write("O número maior é: " + num2 );
	}
}
