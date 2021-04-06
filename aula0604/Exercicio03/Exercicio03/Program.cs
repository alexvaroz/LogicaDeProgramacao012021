using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];

            for (int i = 0; i <numeros.Length; i++)
            {
                numeros[i] = i * i;
            }

            Console.WriteLine($"O elemento 2 é {numeros[2]}");
            Console.WriteLine($"O elemento 5 é {numeros[5]}"); // Dá erro devido à tentativa de acesso a posição inexistente

            Console.ReadLine();

        }
    }
}
