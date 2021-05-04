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
            int[] sequenciaNumeros = { 1, 2, 3, -4, 5, 6 };
            
            if (ChecarSeTodosNumerosPositivos(sequenciaNumeros))
            {
                Console.WriteLine("Todos os números da sequência são verdadeiros!!!");
            } else
            {
                Console.WriteLine("Existe ao menos um números negativo na sequencia!!!");
            }
            Console.ReadLine();

        }

        static bool ChecarSeTodosNumerosPositivos(int[] numeros)
        {
            bool todosNumerosPositivos = true;
            foreach (var elemento in numeros)
            {
                if (elemento < 0)
                {
                    todosNumerosPositivos = false;
                }
            }
            return todosNumerosPositivos;
        }
    }
}
