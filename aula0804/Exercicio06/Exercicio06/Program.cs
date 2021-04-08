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
            // Declaração
            int[,] minhaMatriz;
            // Alocação e Inicialização
            minhaMatriz = new int[3, 3] { { 8, 9, 14 }, { 7, 4, 12 }, { 0, -3, 8 } };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Elemento da linha {i}, coluna {j} é {minhaMatriz[i, j]}");
                }
            }

            Console.ReadLine();

        }
    }
}
