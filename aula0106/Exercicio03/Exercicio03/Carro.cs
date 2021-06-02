using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Carro
    {
        string cor;
        int anoFabricacao;
        string modelo;
        float velocidadeAtual = 0;
        float velocidadeMaxima;
        bool ligado = false;

        public Carro(string cor, int anoFabricacao, string modelo, float velocidadeAtual, float velocidadeMaxima, bool ligado)
        {
            this.cor = cor;
            this.anoFabricacao = anoFabricacao;
            this.modelo = modelo;
            this.velocidadeAtual = velocidadeAtual;
            this.velocidadeMaxima = velocidadeMaxima;
            this.ligado = ligado;
        }

        public void Ligar()
        {
            if (ligado)
            {
                Console.WriteLine("Opa... O carro já está ligado...");
            } else
            {
                ligado = true;
                Console.WriteLine("O carro foi ligado!!!!");
            }
        }

        public void Acelerar(float aceleracao)
        {
            if (!ligado)
            {
                Console.WriteLine("O carro está desligado...");
                return;
            }
            if (velocidadeAtual < velocidadeMaxima)
            {
                velocidadeAtual = velocidadeAtual + aceleracao;
                if (velocidadeAtual >= velocidadeMaxima)
                {
                    velocidadeAtual = velocidadeMaxima;
                }
            }
            Console.WriteLine($"Depois de acelerar, velocidade atual do carro: {velocidadeAtual} km/h");
        }

        public void Frear(float frenagem)
        {
            if (!ligado)
            {
                Console.WriteLine("O carro está desligado...");
                return;
            }
            if (velocidadeAtual > 0)
            {
                velocidadeAtual = velocidadeAtual - frenagem;
                if (velocidadeAtual <= 0)
                {
                    velocidadeAtual = 0;
                }
            }
            Console.WriteLine($"Depois de frear, velocidade atual do carro: {velocidadeAtual} km/h");
        }
    }
}
