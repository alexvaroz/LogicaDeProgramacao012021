using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] times = { "Flamengo", "Mengão", "O mais querido", "Bicampeão da Libertadores", "Octocampeão Nacional"};
            ImprimirValoresArray(times);
            ImprimirValoresArrayComRecursao(times, times.Length);
            Console.ReadLine();
        }

        static void ImprimirValoresArray(string[] palavras)
        {
            foreach (var item in palavras)
            {
                Console.WriteLine(item);
            }
        }

        static void ImprimirValoresArrayComRecursao(string[] palavras, int tamanhoArray)
        {
            if (tamanhoArray == 0)
            {
                return;
            } else
            {
                Console.WriteLine(palavras[tamanhoArray - 1]);
                ImprimirValoresArrayComRecursao(palavras, tamanhoArray - 1);
            }
        }
    }
}
