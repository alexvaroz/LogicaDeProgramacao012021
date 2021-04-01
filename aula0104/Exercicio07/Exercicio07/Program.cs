using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorTotal, valorRestante;
            int quantidadeNotas100, quantidadeNotas50, quantidadeNotas20, quantidadeNotas10,
                quantidadeNotas5, quantidadeNotas2, quantidadeNotas1;
            Console.WriteLine("Bom dia!!!\n" +
                "Digite o valor que deseja retirar: ");
            valorTotal = int.Parse(Console.ReadLine());
            quantidadeNotas100 = valorTotal / 100;
            valorRestante = valorTotal % 100;
            quantidadeNotas50 = valorRestante / 50;
            valorRestante = valorRestante % 50;
            quantidadeNotas20 = valorRestante / 20;
            valorRestante = valorRestante % 20;
            quantidadeNotas10 = valorRestante / 10;
            valorRestante = valorRestante % 10;
            quantidadeNotas5 = valorRestante / 5;
            valorRestante = valorRestante % 5;
            quantidadeNotas2 = valorRestante / 2;
            quantidadeNotas1 = valorRestante % 2;

            Console.WriteLine($"Quantidade de notas de 100: {quantidadeNotas100}");
            Console.WriteLine($"Quantidade de notas de  50: {quantidadeNotas50}");
            Console.WriteLine($"Quantidade de notas de  20: {quantidadeNotas20}");
            Console.WriteLine($"Quantidade de notas de  10: {quantidadeNotas10}");
            Console.WriteLine($"Quantidade de notas de   5: {quantidadeNotas5}");
            Console.WriteLine($"Quantidade de notas de   2: {quantidadeNotas2}");
            Console.WriteLine($"Quantidade de notas de   1: {quantidadeNotas1}");
            Console.ReadLine();


        }
    }
}
