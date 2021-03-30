using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            int anosDeEmpresa;
            float salario;

            Console.WriteLine("Digite a quantidade de anos na empresa:");
            anosDeEmpresa = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do seu último salário recebido:");
            salario = float.Parse(Console.ReadLine());
            if (anosDeEmpresa >= 5)
                Console.WriteLine($"O valor do seu bônus será {(salario * 0.20).ToString("C")} .");
            else
                Console.WriteLine($"O valor do seu bônus será {(salario * 0.10).ToString("C")} .");
            Console.ReadLine();
        }
    }
}
