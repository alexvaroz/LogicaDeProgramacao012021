using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introducao_listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> minhaLista = new List<int>();
            int numeroDeElementos = minhaLista.Count;
            minhaLista.Add(33);
            minhaLista.Add(50);
            minhaLista.Add(67);
            Console.WriteLine(minhaLista.Count);
            Console.WriteLine(minhaLista[1]);
            minhaLista.Insert(3, 45);
            minhaLista.Insert(1, 25);
            Console.WriteLine(minhaLista.Count);
            Console.WriteLine($"A posição 2 agora conta o valor {minhaLista[2]}");
            minhaLista.Insert(5, 100);
            minhaLista.Insert(6, 150);
            Console.WriteLine(minhaLista.Count);
            Console.ReadLine();
        }
    }
}
