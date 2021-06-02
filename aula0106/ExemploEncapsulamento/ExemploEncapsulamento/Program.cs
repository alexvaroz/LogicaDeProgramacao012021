using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEncapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Cachorro capitu = new Cachorro("Capitú", "Fila", 4);
            
            Console.WriteLine($"A cadela se chama {capitu.Nome}, é da raça {capitu.Raca} e tem {capitu.Idade} anos.");
            Console.ReadLine();

            Animal foca = new Animal("Focollis", "fêmea");

            Console.WriteLine($"O animal é da espécie {foca.Especie} e é um(a) {foca.Genero}.");
            Console.ReadLine();
        }
    }
}
