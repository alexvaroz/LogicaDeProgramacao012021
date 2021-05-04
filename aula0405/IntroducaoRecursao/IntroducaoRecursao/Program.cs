using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroducaoRecursao
{
    class Program
    {
        static void Main(string[] args)
        {
            ImprimirFraseRepetidasVezesComRecursao("Tenho que estudar mais recursão!!!", 5);
            ImprimirFraseRepetidasVezes("Tenho que estudar mais!!!", 5);
            Console.ReadLine();
        }

        static void ImprimirFraseRepetidasVezes(string frase, int numeroVezes)
        {
            for (int i = 0; i < numeroVezes; i++)
            {
                Console.WriteLine(frase);
            }
        }

        static void ImprimirFraseRepetidasVezesComRecursao(string frase, int numeroVezes)
        {
            if (numeroVezes > 0)
            {
                Console.WriteLine(frase);
                ImprimirFraseRepetidasVezesComRecursao(frase, numeroVezes - 1);
            }
        }
    }
}
