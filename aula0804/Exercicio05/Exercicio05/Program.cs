using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] notas = new float[5];
            float media;
            float somaNotas = 0;

            Console.WriteLine("Bom dia!!! Digite suas notas:");
            for (int i = 0; i < notas.Length; i++)
            {
                notas[i] = float.Parse(Console.ReadLine());
            }

            Console.WriteLine("Clique para verificar as notas registradas e a média:");
            Console.ReadLine();

            foreach (var item in notas)
            {
                Console.WriteLine(item);
                somaNotas += item;
            }
            media = somaNotas / notas.Length;

            Console.WriteLine($"A média das notas é {media}.");
            Console.ReadLine();
        }
    }
}
