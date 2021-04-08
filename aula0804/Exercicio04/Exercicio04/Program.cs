using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            int maiorValor, menorValor;

            // Declaração e alocação
            int[] valores = new int[10];

            Random rnd = new Random();

            for (int i = 0; i < valores.Length; i++)
            {
                valores[i] = rnd.Next(-100, 100);
            }

            maiorValor = valores[0];
            menorValor = valores[0];

            foreach (var item in valores)
            {
                if (item >= maiorValor)
                {
                    maiorValor = item;
                }
                if (item <= menorValor)
                {
                    menorValor = item;
                }
            }

            // Vamos imprimir os valores do Array
            foreach (var item in valores)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            Console.WriteLine($"O maior valor é {maiorValor}");
            Console.WriteLine($"O menor valor é {menorValor}");
            Console.ReadLine();
        }
    }
}
