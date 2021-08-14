using System;

namespace Atividade_aula9Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta1 = new Conta();
            Cliente c1 = new Cliente();

            conta1.Agencia = "12345";
            conta1.Numero = 10;
            conta1.Saldo = 205.30F;

            c1.Nome = "Igor";
            c1.Sobrenome = "Mozetic";
            c1.Cpf = "999.888.777-66";
            c1.Conta = conta1;

            Console.WriteLine("As informações da Conta 1 são:\nAgencia: " + c1.Conta.Agencia + "\nNúmero: " + c1.Conta.Numero + "\nSaldo: " + c1.Conta.Saldo);
            Console.WriteLine("\n\nAs Informações do cliente 1 são:\nNome: " + c1.Nome + "\nSobrenome: " + c1.Sobrenome + "\nCPF: " + c1.Cpf);

            Conta conta2 = new Conta();
            Cliente c2 = new Cliente();

            conta2.Agencia = "67890";
            conta2.Numero = 20;
            conta2.Saldo = 102.20F;

            c2.Nome = "Madu";
            c2.Sobrenome = "Perose";
            c2.Cpf = "111.222.333-44";
            c2.Conta = conta2;

            Console.WriteLine("\n\nAs informações da Conta 2 são:\nAgencia: " + c2.Conta.Agencia + "\nNúmero: " + c2.Conta.Numero + "\nSaldo: " + c2.Conta.Saldo);
            Console.WriteLine("\n\nAs Informações do cliente 2 são:\nNome: " + c2.Nome + "\nSobrenome: " + c2.Sobrenome + "\nCPF: " + c2.Cpf);

            Conta conta3 = new Conta();
            Cliente c3 = new Cliente();

            conta3.Agencia = "91823";
            conta3.Numero = 30;
            conta3.Saldo = 402.01F;

            c3.Nome = "Ticarica";
            c3.Sobrenome = "Tutz";
            c3.Cpf = "555.666.777-88";
            c3.Conta = conta3;

            Console.WriteLine("\n\nAs informações da Conta 3 são:\nAgencia: " + c3.Conta.Agencia + "\nNúmero: " + c3.Conta.Numero + "\nSaldo: " + c3.Conta.Saldo);
            Console.WriteLine("\n\nAs Informações do cliente 3 são:\nNome: " + c3.Nome + "\nSobrenome: " + c3.Sobrenome + "\nCPF: " + c3.Cpf);

        }
    }
}
