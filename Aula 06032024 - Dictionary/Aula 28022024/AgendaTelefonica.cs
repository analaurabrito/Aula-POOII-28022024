using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_28022024
{
    internal class AgendaTelefonica
    {
        public Dictionary<string, Contato> listaContatos { get; set;}

        public AgendaTelefonica()
        {
            listaContatos = new Dictionary<string, Contato>();
        }

        public void Inserir(string nome, string telefone)
        {
            Contato c = new Contato(nome, telefone);
            listaContatos.Add(nome, c);
            // listaContatos.Add(new Contato(nome, telefone));
        }

        public void Remover(string nome)
        {
            if(listaContatos.Remove(nome))
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
            Contato c = listaContatos[nome];
            if(c != null)
            return listaContatos[nome];
        }

        public int Tamanho()
        {
            return listaContatos.Count;
        }

        public void Imprimir()
        {
            foreach(string n in listaContatos.Keys)
            {
                Console.WriteLine(n + " : " + listaContatos[n].telefone.ToString());
            }
        }


    }
}

