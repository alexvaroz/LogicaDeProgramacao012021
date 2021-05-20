using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introducao_Excecao
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"O resultado da operação é " +
                $"{DividirDoisNumeros(num1, num2)}");
            Console.ReadLine();

        }

        static double DividirDoisNumeros(int num1, int num2)
        {
            double resultado = 0;
            try
            {
                resultado = num1 / num2;
                
            } catch (System.DivideByZeroException)
            {
                Console.WriteLine("Não é possível dividir por zero... Tente outro número");
            }
            return resultado;
        }
    }
}
