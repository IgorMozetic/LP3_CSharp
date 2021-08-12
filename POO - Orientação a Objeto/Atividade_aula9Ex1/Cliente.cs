using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_aula9Ex1
{
    class Cliente
    {
        private string nome;
        private string sobrenome;
        private string cpf;
        private Conta conta;

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }
        internal Conta Conta { get; set; }
    }
}
