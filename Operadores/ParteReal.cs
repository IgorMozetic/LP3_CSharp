using System;
					
public class ParteReal
{
	public static void Main()
	{
		double num, parte;	
		Console.WriteLine("Entre com um numero real:");
		num = double.Parse(Console.ReadLine());
		parte = num / 5;

            Console.WriteLine("A quinta parte do numero inserido é: " + parte);
        
	}
}
