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
            int[] numeros = { 12, 4, 565, -4 };
            Console.WriteLine($"O maior valor do array é {ObterMaiorNumeroArray(numeros)}");

            Console.WriteLine($"O maior valor do array é {ObterMaiorNumeroArrayComRecursao(numeros, numeros.Length)}");
            Console.ReadLine();
        }

        // Usando iteração
        static int ObterMaiorNumeroArray(int[] numeros)
        {
            int maiorValor = numeros[0];
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > maiorValor)
                {
                    maiorValor = numeros[i];
                }
            }
            return maiorValor;
        }

        // Usando recursão
        static int ObterMaiorNumeroArrayComRecursao(int[] numeros, int qtdeElementosArray)
        {
            if (qtdeElementosArray == 1)
            {
                return numeros[0];
            }
            if (numeros[qtdeElementosArray - 1] >= ObterMaiorNumeroArrayComRecursao(numeros, qtdeElementosArray - 1))
            {
                return numeros[qtdeElementosArray - 1];
            } else
            {
                return ObterMaiorNumeroArrayComRecursao(numeros, qtdeElementosArray - 1);
            }
        }
    }
}
