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
            Console.WriteLine(CalcularPotenciacaoDoisNumeros(13, 8));
            Console.WriteLine(CalcularPotenciacaoDoisNUmerosComRecursao(13, 8));
            Console.ReadLine();
        }

        static int CalcularPotenciacaoDoisNumeros(int num1, int num2)
        {
            int resultado = 1;
            for (int i = 0; i < num2; i++)
            {
                resultado = resultado * num1;
            }
            return resultado;
        }

        static int CalcularPotenciacaoDoisNUmerosComRecursao(int num1, int num2)
        {
            int resultado = 1;
            if (num2 > 0)
            {
                resultado = num1 * CalcularPotenciacaoDoisNUmerosComRecursao(num1, num2 - 1);
            }
            return resultado;
        }
    }
}
