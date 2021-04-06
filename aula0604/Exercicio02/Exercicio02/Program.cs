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
            // Declarar
            string[] diasDaSemana;

            // Alocar
            diasDaSemana = new string[7];

            // Inicializar
            diasDaSemana[0] = "Domingo";
            diasDaSemana[1] = "Segunda-feira";
            diasDaSemana[2] = "Terça-feira";
            diasDaSemana[3] = "Quarta-feira";
            diasDaSemana[4] = "Quinta-feira";
            diasDaSemana[5] = "Sexta-feira";
            diasDaSemana[6] = "Sábado";

            string[] diasDaSemanaNovo = {"Domingo", "Segunda-feira", "Terça-feira", "Quarta-feira",
                    "Quinta-feira", "Sexta-feira", "Sábado"};

            string[] diasDaSemanaNovoDois = new string[7]{"Domingo", "Segunda-feira", "Terça-feira", "Quarta-feira",
                    "Quinta-feira", "Sexta-feira", "Sábado"};

            string[] diasDaSemanaNovoTres = new string[]{"Domingo", "Segunda-feira", "Terça-feira", "Quarta-feira",
                    "Quinta-feira", "Sexta-feira", "Sábado"};


            Console.WriteLine($"Hoje é {diasDaSemanaNovoDois[2]}");
            Console.WriteLine($"Ontem foi {diasDaSemanaNovoDois[1]}, e amanhã será {diasDaSemanaNovoDois[3]}");
            Console.ReadLine();

            Console.WriteLine(diasDaSemanaNovoTres.Length);
            Console.ReadLine();
        }
    }
}
