using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEncapsulamento
{
    class Animal
    {
        public Animal(string especie, string genero)
        {
            Especie = especie;
            Genero = genero;
        }

        public string Especie { get; private set; }
        public string Genero { get; }
    }
}
