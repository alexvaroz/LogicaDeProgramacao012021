using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            numero = 5;
            Console.WriteLine($"O valor inicial da variável \"Número\" é {numero}.");
            Console.ReadLine();
            numero += 8; // numero = numero + 8
            Console.WriteLine($"O valor atual da variável \"Número\" é {numero}.");
            Console.ReadLine();
            numero -= 8; // numero = numero - 8
            Console.WriteLine($"O valor atual da variável \"Número\" é {numero}.");
            Console.ReadLine();
            numero++; // numero = numero + 1
            Console.WriteLine($"O valor atual da variável \"Número\" é {numero}.");
            Console.ReadLine();
            numero--; //numero = numero - 1
            Console.WriteLine($"O valor atual da variável \"Número\" é {numero}.");
            Console.ReadLine();
            bool estaPresente = true;
            bool participouDaAula = false;
            Console.WriteLine($"Valeu a pena: {estaPresente && participouDaAula}");
            Console.ReadLine();
            Console.WriteLine($"Valeu a pena: {estaPresente || participouDaAula}");
            Console.ReadLine();
            Console.WriteLine($"Valeu a pena: {estaPresente | participouDaAula}");
            Console.ReadLine();
            Console.WriteLine($"Valeu a pena: {estaPresente & participouDaAula}");
            Console.ReadLine();


        }
    }
}
