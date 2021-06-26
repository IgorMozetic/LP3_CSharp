using System;
					
public class Salario
{
	public static void Main()
	{
		double salario, prestacao;
		Console.WriteLine("Entre com o seu salário: ");
		salario = double.Parse(Console.ReadLine());
		Console.WriteLine("Entre com o valor da prestação do empréstimo: ");
		prestacao = double.Parse(Console.ReadLine());
		
		if ( (salario/5) > prestacao)
			Console.WriteLine("Empréstimo concedido");
	 	else
			Console.WriteLine("Empréstimo não concedido");
		
			
	}
}
