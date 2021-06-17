using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao03
{
    class Program
    {
        /* Escreva uma função (ou método) em C# que receba um array de inteiros e imprima na 
         * tela a soma de todos os elementos.
         */

        static void Main(string[] args)
        {
            // Declaração
            int[] arrayTeste;
            // Alocação
            arrayTeste = new int[6];
            // Implementação
            arrayTeste[0] = 9;
            arrayTeste[1] = 10;
            arrayTeste[2] = 2;
            arrayTeste[3] = -4;
            arrayTeste[4] = 8;
            arrayTeste[5] = -12;

            SomarElementosDoArray(arrayTeste);
            Console.ReadLine();

        }

        static void SomarElementosDoArray(int[] numeros)
        {
            int soma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                soma = soma + numeros[i];
            }
            Console.WriteLine($"A soma dos elementos do array é {soma}");
        }



    }
}
