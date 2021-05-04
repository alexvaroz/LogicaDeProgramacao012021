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
            int[] numeros = CriarArrayDezNumerosInteiros();
            ImprimirMaiorValorArray(numeros);
            Console.ReadLine();

        }

        static int[] CriarArrayDezNumerosInteiros()
        {
            int[] numeros = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = rnd.Next(-100, 100);
            }
            return numeros;
        }

        static void ImprimirMaiorValorArray(int[] numeros)
        {
            int maiorValor = numeros[0];
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > maiorValor)
                {
                    maiorValor = numeros[i];
                }
            }
            Console.WriteLine($"O maior valor do array é {maiorValor}");
        }
    }
}
