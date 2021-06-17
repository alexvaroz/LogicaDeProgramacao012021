using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao04
{
    class Program
    {
        /* 
         * Criar uma função em C# que retorne o maior número encontrado em uma matriz de inteiros.
         */

        static void Main(string[] args)
        {
            int[,] matrizTeste = { { 3, 16, 7 }, { 4, 8, 2 } };
            Console.WriteLine($"O maior valor da matriz é {RetornarMaiorValorMatriz(matrizTeste)}");
            Console.ReadLine();
        }

        static int RetornarMaiorValorMatriz(int[,] matriz)
        {
            int maiorValor = matriz[0, 0];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i,j] > maiorValor)
                    {
                        maiorValor = matriz[i, j];
                    }
                }
            }
            return maiorValor;
        }
    }
}
