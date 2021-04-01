using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            // Primeira opção
            for (int i = 3; i <= 100; i+=3)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

            // Segunda opção
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    Console.WriteLine(i);
            }
            Console.ReadLine();

            // Terceira opção
            var numero = 1;
            while (numero <= 100)
            {
                if (numero % 3 == 0)
                    Console.WriteLine(numero);
                numero++;
            }
            Console.ReadLine();

        }
    }
}
