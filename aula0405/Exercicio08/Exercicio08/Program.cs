using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro:");
            int numeroDigitado = int.Parse(Console.ReadLine());
            Console.WriteLine($"O último algarismo do número é {RetornarUltimoAlgarismoPorExtenso(numeroDigitado)}");
            Console.ReadLine();
        }

        static string RetornarUltimoAlgarismoPorExtenso(int numero)
        {
            int ultimoAlgarismo = numero % 10;
            string[] algarismosPorExtenso = {"zero", "um", "dois", "três", "quatro", "cinco", "seis",
            "sete", "oito", "nove"}; 

            return algarismosPorExtenso[ultimoAlgarismo];
        }


    }
}
