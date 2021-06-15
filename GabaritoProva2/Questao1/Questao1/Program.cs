using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao1
{
    class Program
    {
        /* 
         * Implementar um método que receba uma matriz QUADRADA e retorne a soma da sua diagonal principal. Caso a matriz 
         * informada pelo usuário não seja quadrada, o método deve lançar uma exceção criada especificamente para esse caso. 
         * P.S. A classe da exceção solicitada também deverá constar na resposta.
         */
        
        static void Main(string[] args)
        {
            int[,] matrizQuadrada = { { 3, 5, 7 }, { 2, 4, 6 }, { 3, 6, 9 } };
            int[,] matrizNaoQuadrada = { { 3, 5, 7 }, { 2, 4, 6 } };
            try
            {
                Console.WriteLine($"A soma da diagonal principal é {CalcularSomaDiagonalPrincipalMatrizQuadrada(matrizQuadrada)}");
                Console.WriteLine($"A soma da diagonal principal é {CalcularSomaDiagonalPrincipalMatrizQuadrada(matrizNaoQuadrada)}");
            } catch (MatrizNaoQuadradaException mnqe)
            {
                Console.WriteLine(mnqe.Message);
            }

            Console.ReadLine();
        }

        static int CalcularSomaDiagonalPrincipalMatrizQuadrada(int[,] matriz)
        {
            if (matriz.GetLength(0) != matriz.GetLength(1))
            {
                throw new MatrizNaoQuadradaException("A matriz não é quadrada");
            }
            int soma = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                soma = soma + matriz[i, i];
            }
            return soma;
        }
    }

    class MatrizNaoQuadradaException : ApplicationException
    {
        public MatrizNaoQuadradaException(string mensagem) : base(mensagem) {}
    }
}
