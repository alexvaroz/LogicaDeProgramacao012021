using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao05
{
    class Program
    {
        /*
         * Crie uma classe de nome "Carro" com as seguintes informações:
         * Atributos: Modelo, AnoFabricação, VelocidadeMaxima, VelocidadeAtual
         * Métodos: Acelerar, Freiar
         */

        static void Main(string[] args)
        {
            Carro meuCarro = new Carro("Fusca", 2001, 150);
            meuCarro.Acelerar();
            meuCarro.Acelerar();
            meuCarro.Acelerar();
            meuCarro.Frear();
            meuCarro.Acelerar();
            meuCarro.Acelerar();
            meuCarro.Acelerar();
            meuCarro.Acelerar();
            meuCarro.Acelerar();
            meuCarro.Acelerar();
            meuCarro.Acelerar();
            meuCarro.Acelerar();
            meuCarro.Acelerar();
            meuCarro.Acelerar();
            meuCarro.Acelerar();
            meuCarro.Acelerar();
            Console.WriteLine($"Valor da velocidade atual do carro: {meuCarro.VelocidadeAtual} km/h");
            Console.ReadLine();
        }
    }
}
