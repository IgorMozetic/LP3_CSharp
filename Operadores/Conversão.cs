using System;
					
public class Conversão
{
	public static void Main()
	{
		double c, f;
		Console.Write("Entre com a temperatura em Celsius: ");
            c = double.Parse(Console.ReadLine());
   			 f = c * (9.0/5.0) + 32.0;
				Console.Write("A temperatura inserida em Fahrenheit é: " +f +"°F");

	}
}
