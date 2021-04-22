using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar lista de strings
            // Declaração
            List<string> nomeAlunos;

            // Inicialização
            nomeAlunos = new List<string>();

            Console.WriteLine($"Tamanho inicial da lista: {nomeAlunos.Count}");

            /* 
             * Experimentar os métodos: Count, Add, Insert, Remove, RemoveAt, Clear, 
             * IndexOf, Sort, Reverse
             */

            nomeAlunos.Add("Lucas");
            nomeAlunos.Add("Wellington");

            Console.WriteLine($"Tamanho atual da lista: {nomeAlunos.Count}");

            nomeAlunos.Add("Jonathan");
            nomeAlunos.Add("Maycon");
            Console.WriteLine($"Tamanho atual da lista: {nomeAlunos.Count}");
            Console.WriteLine($"Aluno na posição 2: {nomeAlunos[2]}");
            nomeAlunos.Insert(2, "Antonio");
            Console.WriteLine($"Aluno na posição 2: {nomeAlunos[2]}");
            nomeAlunos.Insert(5, "William");
            Console.WriteLine($"Tamanho atual da lista: {nomeAlunos.Count}");
            nomeAlunos.Add("Bob Nelson");
            nomeAlunos.Add("Bob Nelson");
            Console.WriteLine($"Tamanho atual da lista: {nomeAlunos.Count}");
            nomeAlunos.Remove("Bob Nelson");
            Console.WriteLine($"Tamanho atual da lista após remoção do Bob: {nomeAlunos.Count}");
            nomeAlunos.Add("Bob Nelson");
            Console.WriteLine($"Tamanho atual da lista após nova inserção do Bob: {nomeAlunos.Count}");
            nomeAlunos.RemoveAt(0);
            Console.WriteLine($"Tamanho atual da lista: {nomeAlunos.Count}");
            foreach (string aluno in nomeAlunos)
            {
                Console.WriteLine(aluno);
            }
            nomeAlunos.RemoveAt(0);
            Console.WriteLine($"Nova relação de alunos:");
            foreach (string aluno in nomeAlunos)
            {
                Console.WriteLine(aluno);
            }
            nomeAlunos.RemoveAt(nomeAlunos.Count - 1);
            Console.WriteLine($"Nova relação de alunos:");
            foreach (string aluno in nomeAlunos)
            {
                Console.WriteLine(aluno);
            }

            // IndexOf
            Console.WriteLine($"A posição do Maycon na lista é {nomeAlunos.IndexOf("Maycon")}");
            Console.ReadLine();

            // Sort
            nomeAlunos.Sort();
            Console.WriteLine($"Lista dos alunos ordenada de forma crescente:");
            foreach (string aluno in nomeAlunos)
            {
                Console.WriteLine(aluno);
            }

            // Reverse
            nomeAlunos.Reverse();
            Console.WriteLine($"Lista dos alunos ordenada de forma crescente:");
            foreach (string aluno in nomeAlunos)
            {
                Console.WriteLine(aluno);
            }

            // Clear
            nomeAlunos.Clear();
            Console.WriteLine($"Tamanho atual da lista: {nomeAlunos.Count}");



            Console.ReadLine();
        }
    }
}
