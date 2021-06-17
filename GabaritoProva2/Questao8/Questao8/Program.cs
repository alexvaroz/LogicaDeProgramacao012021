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
            int numeroTeste = 100;
            Console.WriteLine($"A quantidade de algarismos do número " +
                $"{numeroTeste} é {CalcularQuantidadeDeAlgarismosDoNumero(numeroTeste)} ");
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

        public static int contarAlgorismos(int numeros, int digitos)
        {
            if (numeros == 0)
                return digitos;

            return contarAlgorismos(numeros / 10, ++digitos);
        }

        static int CalcularQuantidadeDeAlgarismosDoNumero(int algarismos)
        {
            int resultado = 1;
            if (algarismos >= 10)
            {
                algarismos = algarismos / 10;
                resultado = resultado + CalcularQuantidadeDeAlgarismosDoNumero(algarismos);
            }

            return resultado;
        }
    }
}
