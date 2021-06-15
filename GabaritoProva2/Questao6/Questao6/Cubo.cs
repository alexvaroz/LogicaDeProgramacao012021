using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao6
{
    class Cubo
    {
        private int aresta;

        public int Aresta { get => aresta; set => aresta = value; }

        public int CalcularVolume()
        {
            return aresta * aresta * aresta;
        }
    }
}
