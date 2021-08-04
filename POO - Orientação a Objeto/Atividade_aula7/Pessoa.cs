using System;

namespace Atividade_aula7
{
    public class Pessoa
    {
        private string nome = "Igor", sobrenome;
        private byte idade;
        private float altura, peso;
        public void setNome(String nome)
        {
            this.nome = nome;
        }
        public String getNome()
        {
            return nome;
        }
    }
}
