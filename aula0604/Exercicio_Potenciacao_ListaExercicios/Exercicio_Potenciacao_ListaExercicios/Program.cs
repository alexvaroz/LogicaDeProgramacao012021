using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Potenciacao_ListaExercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero_base, numero_expoente;
            int resultado = 1;
            Console.WriteLine("Digite o número da base:");
            numero_base = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número do expoente:");
            numero_expoente = int.Parse(Console.ReadLine());

            if (numero_expoente > 0)
            {
                for (int i = 1; i <= numero_expoente; i++)
                {
                    resultado = resultado * numero_base;
                }
            }
            Console.WriteLine(resultado);
            Console.ReadLine();
        }
    }
}
