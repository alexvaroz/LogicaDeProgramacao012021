using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois números inteiros:");
            int numeroA = int.Parse(Console.ReadLine());
            int numeroB = int.Parse(Console.ReadLine());
            ImprimirMaiorValorEntreDoisNumeros(numeroA, numeroB);
            Console.ReadLine();
        }

        static void ImprimirMaiorValorEntreDoisNumeros(int numero1, int numero2)
        {
            int maiorValor;
            if (numero1 > numero2)
            {
                maiorValor = numero1;
            } else
            {
                maiorValor = numero2;
            }
            Console.WriteLine($"O maior número é o {maiorValor}");
        }
    }
}
