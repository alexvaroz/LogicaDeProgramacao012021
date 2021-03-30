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
            int numero1, numero2;
            char operacao;

            Console.WriteLine("Informe o primeiro número da operação:");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo número da operação:");
            numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a operação que deseja realizar:");
            Console.WriteLine(" + para adição");
            Console.WriteLine(" - para subtração");
            Console.WriteLine(" * para multiplicação");
            Console.WriteLine(" / para divisão");
            operacao = char.Parse(Console.ReadLine());

            switch (operacao)
            {
                case '+':
                    Console.WriteLine($"O resultado da soma é {numero1 + numero2}");
                    break;
                case '-':
                    Console.WriteLine($"O resultado da subtração é {numero1 - numero2}");
                    break;
                case '*':
                    Console.WriteLine($"O resultado da multiplicação é {numero1 * numero2}");
                    break;
                case '/':
                    Console.WriteLine($"O resultado da divisão é {(float)numero1 / numero2}");
                    break;
                default:
                    Console.WriteLine("Operação não identificada... Tente outra vez...");
                    break;
            }
            Console.ReadLine();
        }
    }
}
