using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_aula9Ex2
{
    class Usuario
    {
        private string nome;
        private string sobrenome;
        private string senha;
        private Postagem[] postagens = new Postagem[3];

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Senha { get; set; }
        internal Postagem[] Postagens { get; set; }
    }
}