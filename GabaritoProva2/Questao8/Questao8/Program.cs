using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao8
{
    class Program
    {
        /* 
         * Desenvolva um método que, utilizando RECURSÃO, conte o número de algarismos de um número inteiro. 
         */

        static void Main(string[] args)
        {
            int numeroTeste = 789123;
            Console.WriteLine($"A quantidade de algarismos do número " +
                $"{numeroTeste} é {RetornarQuantidadeAlgarismosNumero(numeroTeste)} ");
            Console.ReadLine();
        }

        static int RetornarQuantidadeAlgarismosNumero(int numero)
        {
            if ((numero / 10) == 0)
            {
                return 1;
            }

            return 1 + RetornarQuantidadeAlgarismosNumero(numero / 10);
        }
    }
}
