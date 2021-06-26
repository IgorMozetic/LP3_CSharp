using System;
					
public class Opcao
{
	public static void Main()
	{
		string opcao = "sim";
		switch (opcao)
		{
			case "sim":
				Console.WriteLine("Você escolheu a opção SIM");
		break;
			case "não":
			case "talvez":
				Console.WriteLine("Você não escolheu a opção SIM");
				break;
			default:
				Console.WriteLine("A opção digitada é inválida");
				break;
		}
	}
}
