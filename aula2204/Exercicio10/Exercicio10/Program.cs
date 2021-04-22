using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar a lista com 30 inteiros aletórios entre -100 e 100.
            List<int> listaNumerosAleatorios = new List<int>();
            List<int> listaNumerosNaoNegativos = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < 30; i++)
            {
                int numero = rnd.Next(-100, 100);
                listaNumerosAleatorios.Add(numero);
            }
            Console.WriteLine($"Tamanho da lista criada: {listaNumerosAleatorios.Count}");
            Console.WriteLine($"Elementos da lista:");
            foreach (var numero in listaNumerosAleatorios)
            {
                Console.WriteLine(numero);
            }

            for (int i = 0; i < listaNumerosAleatorios.Count; i++)
            {
                if (listaNumerosAleatorios[i] >= 0)
                {
                    listaNumerosNaoNegativos.Add(listaNumerosAleatorios[i]);
                }
            }

            Console.WriteLine($"Nova versão da lista:");
            foreach (var numero in listaNumerosNaoNegativos)
            {
                Console.WriteLine(numero);
            }
            Console.WriteLine($"Novo tamanho da lista: {listaNumerosNaoNegativos.Count}");

            Console.ReadLine();
        }
    }
}
