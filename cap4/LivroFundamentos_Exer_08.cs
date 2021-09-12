using System;

namespace CSharpPratica
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            double raiz, n1, n2, soma;
            Console.WriteLine("Menu de Opções:");
            Console.WriteLine(" 1 - Somar dois números.");
            Console.WriteLine(" 2 - Raiz quadrada de um número.");
            Console.WriteLine("=================================");
            Console.WriteLine("Digite sua opção desejada: ");
            opcao = Convert.ToInt32(Console.ReadLine());

            if (opcao == 1)
            {
                Console.WriteLine("Digite o 1° número: ");
                n1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite o 2° número: ");
                n2 = Convert.ToDouble(Console.ReadLine());
                soma = n1 + n2;
                Console.WriteLine("A soma dos números = {0}", soma);
            }
            else if (opcao == 2)
            {
                Console.WriteLine("Digite o número: ");
                n1 = Convert.ToDouble(Console.ReadLine());
                raiz = Math.Sqrt(n1);
                Console.WriteLine("A raiz quadrada de {0} é {1}", n1, raiz);
            }
            else if(opcao!=1 & opcao != 2)
            {
                Console.WriteLine("Opção Inválida");
            }
        }
    }
}
