using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_28022024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AgendaTelefonica a = new AgendaTelefonica("Ana Laura");
            a.Inserir("Helene", "342794860");
            a.Inserir("Milene", "059483938");
            a.Inserir("Fátima", "558374932");
        }
    }
}
