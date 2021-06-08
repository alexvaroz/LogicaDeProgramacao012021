using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exemplo_Heranca.Classes;

namespace Exemplo_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Humano primeiroHumano = new Humano("Bob", "Nelson");

            Estudante primeiroEstudante = new Estudante("Testolfo", "Rocha", 7);

            Trabalhador primeiroTrabalhador = new Trabalhador("Zé", "da Silva", 2000, 10);

            primeiroEstudante.InformarSeFoiAprovado();
            primeiroEstudante.ImprimirNomeCompleto();


            primeiroHumano.ImprimirNomeCompleto();

            primeiroTrabalhador.ImprimirNomeCompleto();

            primeiroTrabalhador.InformarSalarioPorHora();

            Empresa minhaEmpresa = new Empresa();
            minhaEmpresa.CNPJ = "000.000/00001-1";
            minhaEmpresa.proprietario = primeiroEstudante;

            Console.WriteLine($"" +
                $"O proprietario da empresa é o {minhaEmpresa.proprietario.PrimeiroNome} {minhaEmpresa.proprietario.UltimoNome}");
            

            Console.ReadLine();
        }
    }
}
