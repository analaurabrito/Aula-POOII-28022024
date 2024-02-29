using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_28022024
{
    internal class Contato
    {
        private string nome { get; set; }
        private string telefone { get; set; }

        public Contato(string nome, string telefone)
        {
            this.nome = nome;
            this.telefone = telefone;
        }
    }
}
