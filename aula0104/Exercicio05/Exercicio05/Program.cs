using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            int numero = 1;
            while (numero <= 1000)
            {
                soma = soma + numero;
                numero++;
            }
            Console.WriteLine($"A soma dos 1000 primeiros números é {soma}");
            Console.ReadLine();
        }
    }
}
