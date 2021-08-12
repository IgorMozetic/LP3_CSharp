using System;

namespace Atividade_aula9Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Postagem p1 = new Postagem();
            p1.Titulo = "titulo1";
            p1.Data = "20/02/2020";
            p1.Conteudo = "Macacos me mordam";
            p1.Visitas = 10;

            Postagem p2 = new Postagem();
            p2.Titulo = "titulo2";
            p2.Data = "30/04/2021";
            p2.Conteudo = "Masaue, quem disse isso?";
            p2.Visitas = 290;

            Postagem p3 = new Postagem();
            p3.Titulo = "titulo3";
            p3.Data = "01/07/2021";
            p3.Conteudo = "CLICKBAIT APELATIVASSO";
            p3.Visitas = 1000000;

            Usuario u1 = new Usuario();
            u1.Nome = "Igor";
            u1.Sobrenome = "Mozetic";
            u1.Senha = "12345Igor";
            u1.Postagens[0] = p1;
            u1.Postagens[1] = p2;
            u1.Postagens[2] = p3;

            Console.WriteLine("As informações do Usuário 1 são:\nNome: " + u1.Nome + "\nSobrenome: " + u1.Sobrenome + "\nSenha: " + u1.Senha);
            
            for(int cont=0; cont < 3; cont++) {
                Console.WriteLine("\nA Postagem " + (cont + 1) + " do usuário é:");
                Console.WriteLine("Título: " + u1.Postagens[cont].Titulo);
                Console.WriteLine("Data: " + u1.Postagens[cont].Data);
                Console.WriteLine("Conteudo: " + u1.Postagens[cont].Conteudo);
                Console.WriteLine("Visitas: " + u1.Postagens[cont].Visitas + "\n");
            }
        }
    }
}
