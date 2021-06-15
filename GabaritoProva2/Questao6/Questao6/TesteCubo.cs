using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao6
{
    class TesteCubo
    {
        /* 
         * Para a resolução da questão, siga as seguintes intruções:  (i) Crie uma classe de nome "Cubo" com o seguinte 
         * atributo privado: aresta (int) (ii)	Crie uma propriedade para o acesso a esse atributo. (iii) Crie um método 
         * que retorne o volume do cubo. (obs. O volume de um cubo é sua aresta elevado ao cubo.) (iv) Crie uma classe 
         * "TesteCubo" (com o método main) que crie um objeto do tipo "Cubo” que tenha a aresta valendo 7 e imprima o volume 
         * do cubo executando o método da classe.
         */

        static void Main(string[] args)
        {
            Cubo meuCubo = new Cubo();
            meuCubo.Aresta = 7;
            Console.WriteLine($"O volume do cubo com aresta {meuCubo.Aresta} criado é {meuCubo.CalcularVolume()}.");
            Console.ReadLine();
        }
    }
}
