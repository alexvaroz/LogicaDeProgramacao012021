using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int anoNascimento, anoEleicao;

            Console.WriteLine("Bom dia!!");
            Console.WriteLine("Digite o ano do seu nascimento:");
            anoNascimento = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ano da eleição:");
            anoEleicao = int.Parse(Console.ReadLine());
            if (anoEleicao - anoNascimento >= 16)
                Console.WriteLine($"Você estará apto a votar!! Pois terá {anoEleicao - anoNascimento} anos.");
            else
                Console.WriteLine($"Você não estará apto a votar!! Pois terá apenas {anoEleicao - anoNascimento} anos.");
            Console.ReadLine();
        }
    }
}
