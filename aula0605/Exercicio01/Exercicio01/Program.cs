using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MultiplicarDoisNUmerosSomando(5, 4));
            Console.WriteLine(MultiplicarDoisNumerosSomandoComRecursao(5, 4));
            Console.ReadLine();
        }

        static int MultiplicarDoisNUmerosSomando(int num1, int num2)
        {
            int resultado = 0;
            for (int i = 0; i < num1; i++)
            {
                resultado += num2;
            }
            return resultado;
        }

        static int MultiplicarDoisNumerosSomandoComRecursao(int num1, int num2)
        {
            int resultado = 0;
            if (num2 > 0)
            {
                resultado = num1 + MultiplicarDoisNumerosSomandoComRecursao(num1, num2 - 1);
            }
            return resultado;
        }
    }
}
