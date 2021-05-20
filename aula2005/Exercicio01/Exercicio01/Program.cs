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
            RegistrarNumero();
        }

        private static void RegistrarNumero()
        {
            Console.WriteLine("Insira um número inteiro:");
            try
            {
                int numero = int.Parse(Console.ReadLine());
                Console.WriteLine($"O número digitado foi {numero}.");
            } catch (System.FormatException)
            {
                Console.Clear();
                Console.WriteLine($"Não foi digitado um número inteiro..." +
                    $"Tente novamente...");
                RegistrarNumero();
            }
            Console.ReadLine();
        }
    }
}
