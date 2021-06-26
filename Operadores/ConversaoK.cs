	using System;

	public class ConversaoK
	{
		public static void Main()
		{
			double c, k ;
			Console.Write("Entre com a temperatura em graus Kelvin : ");
			k = double.Parse(Console.ReadLine());
			c = k - 273.15;
			Console.WriteLine("Temperatura convertida em graus Celsius é: " +c +"°C" );
		}
}

	
