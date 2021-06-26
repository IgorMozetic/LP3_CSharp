using System;
					
public class Semana
{
	public static void Main()
	{
		int num;
		
		Console.WriteLine("Entre com um numero inteiro:");
		num = int.Parse(Console.ReadLine());

		switch(num){
	    case 1 :
    		Console.WriteLine("Domingo");
    		break;
    
   		 case 2 :
      		Console.WriteLine ("Segunda");
    		break;
    
		case 3 :
		  	Console.WriteLine ("Terça");
			break;

		case 4 :
		  	Console.WriteLine("Quarta");
			break;

		case 5 :
		  	Console.WriteLine("Quinta");
			break;

		case 6 :
			Console.WriteLine("Sexta");
			break;

		case 7 :
		  	Console.WriteLine("Sabado");
			break;
		}
	}
}
