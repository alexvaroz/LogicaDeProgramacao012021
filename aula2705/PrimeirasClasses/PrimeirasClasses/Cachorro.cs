using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeirasClasses
{
    class Cachorro
    {
        // Atributos
        private string nome;
        public string raca;
        public string genero;
        public int idade;
        public bool estaLatindo = false;

        // Métodos
        public Cachorro() { }

        public Cachorro(string nome_)
        {
            nome = nome_;
        }
        
        
        public void Latir()
        {
            estaLatindo = true;
            Console.WriteLine($"{nome} latindo:");
            Console.WriteLine("Au au au au");
        }

        public void AbanarRabinho()
        {
            Console.WriteLine("Vrap vrap vrap");
        }
    }
}
