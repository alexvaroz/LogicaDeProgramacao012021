using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os limites do intervalo de números:");
            int inicio = int.Parse(Console.ReadLine());
            int fim = int.Parse(Console.ReadLine());
            LerNumeroIntervalo(inicio, fim);
            Console.ReadLine();
        }

        static void LerNumeroIntervalo(int inicio, int fim)
        {
            Console.WriteLine("Digite um número dentro do intervalo:");
            try
            {
                int numeroRecebido = int.Parse(Console.ReadLine());
                if (numeroRecebido >= inicio & numeroRecebido <= fim)
                {
                    Console.WriteLine("O número digitado pertence ao intervalo");
                }
                else
                {
                    throw new ForaDoIntervaloException();
                }
            } 
            catch (FormatException)
            {
                Console.WriteLine("Formato do número inválido...");
                Console.WriteLine("Tente um número inteiro...");
                TentarOutraVez(inicio, fim);
            }
            catch (ForaDoIntervaloException)
            {
                Console.WriteLine("O número digitado não pertence ao intervalo");
                Console.WriteLine($"Tente um número inteiro entre {inicio} e {fim} ");
                TentarOutraVez(inicio, fim);
            }
            catch (Exception)
            {
                Console.WriteLine("Exceção genérica....");
            }
        }

        private static void TentarOutraVez(int inicio, int fim)
        {
            Console.ReadLine();
            Console.Clear();
            LerNumeroIntervalo(inicio, fim);
        }
    }


}
