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
            int num1, num2, num3, maiorValor;
            Console.WriteLine("Digite 3 números inteiros distintos:");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            num3 = int.Parse(Console.ReadLine());


            if (ObterMaiorValor(num1, num2) > num3)
            {
                maiorValor = ObterMaiorValor(num1, num2);
            } else
            {
                maiorValor = num3;
            }

            Console.WriteLine($"O maior valor entre os três números é {maiorValor}");
            Console.ReadLine();
        }

        static int ObterMaiorValor(int numero1, int numero2)
        {
            if (numero1 > numero2)
            {
                return numero1;
            } else 
            {
                return numero2;
            }
        }

        static int ObterMaiorValorDeOutraForma(int numero1, int numero2)
        {
            return (numero1 > numero2) ? numero1 : numero2;
        }
    }
}
