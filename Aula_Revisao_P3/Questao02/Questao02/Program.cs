using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao02
{
    /* 
     * Elabore um programa em C# que imprima todos os números pares de 1 até 100.
     */

    class Program
    {
        static void Main(string[] args)  
        {
            Console.WriteLine("Relação dos números pares entre 1 e 100 (usando 'for'):");
            for (int i = 1; i <= 100; i++)
            {
                if ((i % 2) == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();

            Console.WriteLine("Relação dos números pares entre 1 e 100 (usando 'while'):");
            int numero = 1;
            while (numero <= 100)
            {
                if ((numero % 2) == 0)
                {
                    Console.WriteLine(numero);
                }
                numero++;
            }
            Console.ReadLine();
        }
    }
}
