using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro relampagoMarquinho = new Carro("vermelho", 2010, "corsa", 0, 200, false);
            relampagoMarquinho.Acelerar(30);
            relampagoMarquinho.Ligar();
            relampagoMarquinho.Acelerar(10);
            relampagoMarquinho.Acelerar(20);
            relampagoMarquinho.Acelerar(50);
            relampagoMarquinho.Frear(30);
            relampagoMarquinho.Acelerar(40);
            relampagoMarquinho.Frear(60);
            relampagoMarquinho.Frear(80);
            Console.ReadLine();
        }
    }
}
