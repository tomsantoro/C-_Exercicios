using System;

namespace CSharpPratica
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, resto;
            Console.WriteLine("Digite um número inteiro: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            resto = n1 % 2;
            if (resto==0)
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Ímpar");
            }
        }
    }
}
