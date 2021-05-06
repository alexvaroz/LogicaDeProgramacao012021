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
            Console.WriteLine(CalcularFatorial(0));
            Console.WriteLine(CalcularFatorialComRecursao(0));
            Console.ReadLine();
        }

        static long CalcularFatorial(int numero)
        {
            // 7! = 7*6*5*4*3*2*1= 7*6! = 7*6*5!
            long resultado = 1;
            for (int i = numero; i >= 1; i--)
            {
                resultado = resultado * i;
            }
            return resultado;
        }

        static long CalcularFatorialComRecursao(int numero)
        {
            long resultado = 1;
            if (numero > 0)
            {
                resultado = numero * CalcularFatorialComRecursao(numero - 1);
            }
            return resultado;
        }
    }
}
