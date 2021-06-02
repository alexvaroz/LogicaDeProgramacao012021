using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEncapsulamento
{
    class Cachorro
    {
        string nome;
        string raca;
        int idade;

        public Cachorro(string nome, string raca, int idade)
        {
            this.nome = nome;
            this.raca = raca;
            this.idade = idade;
        }

        public string Nome { get => nome;  }
        public string Raca { get => raca;  }
        public int Idade { get => idade;  }

    }
}
