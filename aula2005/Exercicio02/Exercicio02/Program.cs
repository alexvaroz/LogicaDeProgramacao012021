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
            Console.WriteLine("Insira um número inteiro:");
            int numero = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine($"A raiz quadrada de {numero} é " +
                    $"{CalcularRaizQuadrada(numero)}.");
            } catch (NumeroNegativoException)
            {
                Console.WriteLine("Não é possível calcular a raiz " +
                    "quadrada de números negativos");
            } finally {
                Console.WriteLine("Operação finalizada!");
            }
            Console.ReadLine();
        }

        static double CalcularRaizQuadrada(int numero)
        {
            if (numero < 0)
            {
                throw new NumeroNegativoException();
            }
            return Math.Sqrt(numero);
        }
    }

    public class NumeroNegativoException : ApplicationException
    {
        public NumeroNegativoException() : base() { }
    }
}
