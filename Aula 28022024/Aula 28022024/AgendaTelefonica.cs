using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_28022024
{
    internal class AgendaTelefonica
    {
        List<Contato> listaContatos;
        public string proprietario { get; set; }

        public AgendaTelefonica(string proprietario)
        {
            this.proprietario = proprietario;
            listaContatos = new List<Contato>();
            this.listaContatos = listaContatos;
        }

        public void Inserir(string nome, string telefone)
        {
            Contato c = new Contato(nome, telefone);
            listaContatos.Add(c);
            // listaContatos.Add(new Contato(nome, telefone));
        }

        public void Remover(string nome)
        {
            Contato c = buscar(nome);
            if(listaContatos.Remove(c))
            {
                Console.WriteLine("Removido.")
            }

            else
            {
                Console.WriteLine("Esse contato não existe.")
            }
        }

        public Contato Buscar(string nome)
        {
            foreach(Contato c in listaContatos)
            {
                if(c.nome.Contains(nome))
                {
                    return c;
                }
            }

            return null;
        }

        public int Tamanho()
        {
            return listaContatos.Count;
        }


    }
}
