using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_Heranca
{
    class Humano
    {
        private string primeiroNome;
        private string ultimoNome;

        public Humano(string primeiroNome, string ultimoNome)
        {
            this.primeiroNome = primeiroNome;
            this.ultimoNome = ultimoNome;
        }

        public string PrimeiroNome { get => primeiroNome;  }
        public string UltimoNome { get => ultimoNome; }

        
        public virtual void ImprimirNomeCompleto()
        {
            Console.WriteLine($"{primeiroNome} {ultimoNome}");
        }
    }
 
}
