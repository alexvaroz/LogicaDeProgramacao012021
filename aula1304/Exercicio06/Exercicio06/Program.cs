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
            int[,] minhaMatriz = new int[3,3]{ { 3, 7, 8 }, { 45, 90, 13 }, { 12, 11, 10 } };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(minhaMatriz[i, j]);
                }
            }
            Console.ReadLine();
            
            foreach (var item in minhaMatriz)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }

      


    }
}
