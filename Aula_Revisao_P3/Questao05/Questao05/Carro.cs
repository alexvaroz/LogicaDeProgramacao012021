using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao05
{
    class Carro
    {
        string modelo;
        int anoFabricacao;
        float velocidadeMaxima;
        float velocidadeAtual = 0;

        public Carro(string modelo, int anoFabricacao, float velocidadeMaxima)
        {
            this.modelo = modelo;
            this.anoFabricacao = anoFabricacao;
            this.velocidadeMaxima = velocidadeMaxima;
        }

        public string Modelo { get => modelo; set => modelo = value; }
        public int AnoFabricacao { get => anoFabricacao; set => anoFabricacao = value; }
        public float VelocidadeMaxima { get => velocidadeMaxima; set => velocidadeMaxima = value; }
        public float VelocidadeAtual { get => velocidadeAtual; set => velocidadeAtual = value; }

        public void Acelerar()
        {
            velocidadeAtual = velocidadeAtual + 10;
            if (velocidadeAtual > velocidadeMaxima)
            {
                velocidadeAtual = velocidadeMaxima;
            }
        }

        public void Frear()
        {
            velocidadeAtual = velocidadeAtual - 10;
            if (velocidadeAtual < 0)
            {
                velocidadeAtual = 0;
            }
        }
    }
}
