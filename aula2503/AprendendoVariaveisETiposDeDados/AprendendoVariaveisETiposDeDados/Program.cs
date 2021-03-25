using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoVariaveisETiposDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá mundo!!!");
            Console.WriteLine("Bom dia!!!");
            var idade = 30;
            idade = 28;
            string nome = "Bob Nelson";
            Console.WriteLine("Meu nome é " + nome);
            Console.WriteLine("Minha idade é " + idade);
            string primeiroNome = "Testolfo";
            string sobrenome = "Rocha";
            int minhaIdade = 28;
            float altura = 1.85f;

            Console.WriteLine("Meu nome completo é " + primeiroNome + " " + sobrenome);
            Console.WriteLine("Tenho " + minhaIdade + " anos e " + altura + "m de altura.");
            // Segunda versão
            Console.WriteLine("Meu nome completo é {0} {1}.", primeiroNome, sobrenome);
            Console.WriteLine("Tenho {0} anos e {1}m de altura.", minhaIdade, altura);
            // Terceira versão
            Console.WriteLine($"Meu nome completo é {primeiroNome} {sobrenome}.");
            Console.WriteLine($"Tenho {minhaIdade} anos e {altura}m de altura.");

            string nomeCompleto = Console.ReadLine();
            Console.WriteLine($"O valor digitado foi: {nomeCompleto}");

            // Se não quiser pegar uma string, tem que converter para o tipo que vc quer...
            Console.WriteLine("Digite seu CPF:");
            long numCPF = long.Parse(Console.ReadLine());
            Console.WriteLine($"O CPF digitado é {numCPF}");

            // Versão com preenchimento pelo usuário
            Console.WriteLine("Digite o seu nome:");
            string nomeDigitado = Console.ReadLine();
            Console.WriteLine("Digite o seu sobrenome:");
            string sobrenomeDigitado = Console.ReadLine();
            Console.WriteLine("Digite a sua idade:");
            int idadeDigitada = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a sua altura:");
            double alturaDigitada = double.Parse(Console.ReadLine());
            Console.WriteLine($"O completo é {nomeDigitado} {sobrenomeDigitado}.");
            Console.WriteLine($"Tem {idadeDigitada} anos e {alturaDigitada}m de altura.");
            
            Console.ReadLine();
        }
    }
}
