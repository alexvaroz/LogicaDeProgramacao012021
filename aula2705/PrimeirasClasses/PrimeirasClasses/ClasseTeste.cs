using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeirasClasses
{
    class ClasseTeste
    {
        static void Main(string[] args)
        {
            Cachorro fred = new Cachorro();
            fred.nome = "Fred Mercurio";
            fred.raca = "Chiuaua";
            fred.genero = "macho";
            fred.idade = 2;
            
            Cachorro billy = new Cachorro();
            billy.nome = "Billy Boy";
            billy.raca = "Fila";
            billy.genero = "macho";
            billy.idade = 1;
           
            Cachorro tobias = new Cachorro();            
            tobias.nome = "Tobias Lopes";
            tobias.raca = "PitBull";
            tobias.genero = "macho";
            tobias.idade = 5;

            Cachorro lulu = new Cachorro("Lulu Linda");

            Cachorro[] canil = { tobias, fred, billy, lulu };

            foreach ( Cachorro cachorro in canil)
            {
                cachorro.Latir();
            }

            foreach (Cachorro cachorro in canil)
            {
                cachorro.idade++;
            }

            foreach (Cachorro cachorro in canil)
            {
                Console.WriteLine($"{cachorro.nome} tem {cachorro.idade} anos.");
                cachorro.AbanarRabinho();
            }


            Console.ReadLine();
        }
    }
}
