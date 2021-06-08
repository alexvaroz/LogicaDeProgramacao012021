using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_Heranca
{
    class Trabalhador : Humano
    {
        double salario;
        int quantidadeHorasTrabalhadas;
        double salarioPorHora;


        public Trabalhador(
            string primeiroNome,
            string ultimoNome,
            double salario,
            int quantidadeHorasTrabalhadas
            ) : base(primeiroNome, ultimoNome)
        {
            this.salario = salario;
            this.quantidadeHorasTrabalhadas = quantidadeHorasTrabalhadas;
        }

        public double Salario { get => salario; }
        public int QuantidadeHorasTrabalhadas { get => quantidadeHorasTrabalhadas; }

        public void InformarSalarioPorHora()
        {
            Console.WriteLine($"{PrimeiroNome} {UltimoNome} recebe {Salario / QuantidadeHorasTrabalhadas} reais por hora trabalhada.");
        }
    }
}
