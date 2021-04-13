using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração e alocação
            int[,] matrizQuadrada = new int[4, 4];

            // inicialização
            Random rnd = new Random();
            for (int i = 0; i < matrizQuadrada.GetLength(0); i++)
            {
                for (int  j = 0;  j < matrizQuadrada.GetLength(1);  j++)
                {
                    matrizQuadrada[i, j] = rnd.Next(0,20);
                }
            }

            Console.WriteLine("Imprimindo a Matriz:");
            for (int i = 0; i < matrizQuadrada.GetLength(0); i++)
            {
                for (int j = 0; j < matrizQuadrada.GetLength(1); j++)
                {
                    Console.Write($"{matrizQuadrada[i, j]}     ");
                }
                Console.Write("\n");
            }

            int somaDiagonal = 0, somadiagonal2 = 0;

            for (int i = 0; i < matrizQuadrada.GetLength(0); i++)
            {
                for (int j = 0; j < matrizQuadrada.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        somaDiagonal = somaDiagonal + matrizQuadrada[i,j];
                    }
                }
            }

            for (int i = 0; i < matrizQuadrada.GetLength(0); i++)
            {
                somadiagonal2 += matrizQuadrada[i, i];
            }


            Console.WriteLine($"A soma dos elementos da diagonal principal é {somaDiagonal}.");
            Console.WriteLine($"A soma dos elementos da diagonal principal é {somadiagonal2}.");
            Console.ReadLine();
        }
    }
}
