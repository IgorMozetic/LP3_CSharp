using System;
					
public class Trapézio
{
	public static void Main()
	{
		double basemaior, basemenor, altura;
		
		Console.WriteLine("Entre com a base maior:");
		basemaior=int.Parse(Console.ReadLine());
		Console.WriteLine("Entre com a base menor:");
		basemenor=int.Parse(Console.ReadLine());
		Console.WriteLine("Entre com a altura:");
		altura=int.Parse(Console.ReadLine());

		if( ( basemaior > 0 ) && ( basemenor > 0) )
			Console.WriteLine("A área do trapézio é de: " + ((( basemaior + basemenor ) * altura ) / 2));
		else 
			Console.WriteLine("bases inválidas");}
}
