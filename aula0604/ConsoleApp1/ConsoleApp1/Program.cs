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
            // Versão sem utilizar ARRAY
            int numero1, numero2, numero3, numero4, numero5;
            float media;
            Console.WriteLine("Bom dia!!!");
            Console.WriteLine("Digite os 5 números:");
            numero1 = int.Parse(Console.ReadLine());
            numero2 = int.Parse(Console.ReadLine());
            numero3 = int.Parse(Console.ReadLine());
            numero4 = int.Parse(Console.ReadLine());
            numero5 = int.Parse(Console.ReadLine());

            media = (numero1 + numero2 + numero3 + numero4 + numero5) / 5;
            Console.WriteLine($"A média dos números digitados é {media}");
            Console.ReadLine();

            // Versão utilizando ARRAY
            //Declaração
            int[] numerosDigitados;
            numerosDigitados = new int[5];
            Console.WriteLine("Digite os 5 números:");
            numerosDigitados[0] = int.Parse(Console.ReadLine());
            numerosDigitados[1] = int.Parse(Console.ReadLine());
            numerosDigitados[2] = int.Parse(Console.ReadLine());
            numerosDigitados[3] = int.Parse(Console.ReadLine());
            numerosDigitados[4] = int.Parse(Console.ReadLine());

            media = (numerosDigitados[0] + numerosDigitados[1] + numerosDigitados[2] +
                numerosDigitados[3] + numerosDigitados[4]) / 5;

            Console.WriteLine($"A média dos números digitados é {media}");
            Console.ReadLine();

        }
    }
}
