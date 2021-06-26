using System;
					
public class ConversaoF
{
	public static void Main()
	{
		double c, f;
		Console.Write("Insira a temperatura em Fahrenheit: ");
            f = double.Parse(Console.ReadLine());
   			c = 5.0 * (f - 32.0) / 9.0;
			Console.Write("A temperatura em Celsius é: " +c +"ºC");
	}
}
