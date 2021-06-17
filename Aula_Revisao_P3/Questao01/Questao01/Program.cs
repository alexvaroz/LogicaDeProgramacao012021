using System;

namespace Questao01
{
    class Program
    {
        /*
         * Crie um  programa em C#  no qual o aluno digita duas notas bimestrais e informa 
         * se o aluno foi aprovado ou não. Nota: Considere aprovado se a média aritmética 
         * entre as notas for maior que 5.0.
         */

        static void Main(string[] args)
        {
            float nota1, nota2;
            const float MediaParaPassar = 5;

            Console.WriteLine("Digite a primeira nota:");
            nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota:");
            nota2 = float.Parse(Console.ReadLine());

            if ((nota1+nota2)/2 >= MediaParaPassar)
            {
                Console.WriteLine("Aluno aprovado!!!");
            } else
            {
                Console.WriteLine("Aluno reprovado!!!");
            }
            Console.ReadLine();
        }
    }
}
