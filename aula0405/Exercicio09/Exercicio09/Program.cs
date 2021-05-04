using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = CriarArrayComQuantidadeNumeros(20);
            Console.WriteLine("Digite o número a ser verificado no array:");
            int numeroASerVerificado = int.Parse(Console.ReadLine());
            int numeroDeVezes = RetornarQuantidadeDeVezesQueNumeroRepeteEmArray(numeros, numeroASerVerificado);
            Console.WriteLine($"O número {numeroASerVerificado} aparece {numeroDeVezes} vez(es) no array.");
            Console.ReadLine();

        }

        private static int[] CriarArrayComQuantidadeNumeros(int quantidadeNumeros)
        {
            Random rnd = new Random();
            int[] numeros = new int[quantidadeNumeros];
            for (int i = 0; i < quantidadeNumeros; i++)
            {
                numeros[i] = rnd.Next(0, 20);
            }
            return numeros;
        }

        static int RetornarQuantidadeDeVezesQueNumeroRepeteEmArray(int[] numeros, int numeroVerificar)
        {
            int quantidadeVezes = 0;
            foreach (var item in numeros)
            {
                if (item == numeroVerificar)
                {
                    quantidadeVezes++;
                }
            }
            return quantidadeVezes;
        }
    }
}
