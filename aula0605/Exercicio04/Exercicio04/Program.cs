using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayTeste = { 12, 13, 14, 15 };
            Console.WriteLine($"A soma dos elementos do array é {SomarValoresDoArray(arrayTeste)}");
            Console.WriteLine($"A soma dos elementos do array é {SomarValoresDoArrayComRecursao(arrayTeste, arrayTeste.Length)}");
            Console.ReadLine();
        }

        static int SomarValoresDoArray(int[] numeros)
        {
            int resultado = 0;
            foreach (var item in numeros)
            {
                resultado = resultado + item;
            }
            return resultado;
        }

        static int SomarValoresDoArrayComRecursao(int[] numeros, int tamanhoArray)
        {
            int resultado = 0;
            if (tamanhoArray >= 1)
            {
                resultado = numeros[tamanhoArray - 1] + SomarValoresDoArrayComRecursao(numeros, tamanhoArray - 1);
            }
           
            return resultado;
        }
    }
}
