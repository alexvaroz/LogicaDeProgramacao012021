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
            Console.WriteLine("Digite seu nome:");
            ImprimirNomeTela(Console.ReadLine());
            Console.ReadLine();
        }

        static void ImprimirNomeTela(string nome)
        {
            Console.WriteLine($"O nome digitado foi {nome}");
        }
    }
}
