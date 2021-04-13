using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração e alocação
            int[,] matrizA = new int[2, 5];
            int[,] matrizB = new int[2, 5];
            int[,] matrizC = new int[2, 5];

            // Inicialização
            Random rnd = new Random();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrizA[i, j] = rnd.Next(0, 100);
                    matrizB[i, j] = rnd.Next(0, 100);
                }
            }

            Console.WriteLine("Matriz A:");
            foreach (var item in matrizA)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Matriz B:");
            foreach (var item in matrizB)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrizC[i, j] = matrizA[i, j] + matrizB[i, j];
                }
            }

            Console.WriteLine("Matriz C:");
            for (int i = 0; i < matrizC.GetLength(0); i++)
            {
                for (int j = 0; j < matrizC.GetLength(1); j++)
                {
                    Console.Write($"{matrizC[i,j]}   ");
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
