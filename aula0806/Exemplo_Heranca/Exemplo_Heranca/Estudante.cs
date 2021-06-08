using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_Heranca
{
    class Estudante : Humano
    {
        int nota;

        public Estudante(string primeiroNome, string ultimoNome, int nota) : base(primeiroNome, ultimoNome)
        {
            this.nota = nota;
        }

        public int Nota { get => nota;}


        public void InformarSeFoiAprovado()
        {
            if (nota >= 5)
            {
                Console.WriteLine("O aluno foi aprovado!!");
            } else
            {
                Console.WriteLine("O aluno foi reprovado!!");
            }
        }

        public override void ImprimirNomeCompleto()
        {
            Console.WriteLine($"Nome do estudante {PrimeiroNome} {UltimoNome}");
        }

    }
}
