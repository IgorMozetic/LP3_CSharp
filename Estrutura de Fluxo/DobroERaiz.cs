using System;
					
public class DobroERaiz
{
	public static void Main()
	{
		int num;
		Console.Write("Entre com um número inteiro positivo: ");
		num = int.Parse(Console.ReadLine());
		
		if ( num > 0 ) {
			Console.WriteLine("O quadrado do número inserido é: " + num * num );
			Console.WriteLine("A raiz quadrada do número inserido é: " + Math.Sqrt(num) );
		}
	}
}
