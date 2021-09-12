using System;

namespace CSharpPratica
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4;
            Console.WriteLine("Digite três números em ordem crescente:");
            n1 = Convert.ToDouble(Console.ReadLine());
            n2 = Convert.ToDouble(Console.ReadLine());
            n3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite um número qualquer: ");
            n4 = Convert.ToDouble(Console.ReadLine());

            if (n4 > n3)
            {
                Console.WriteLine("A ordem decrescente é: {0}, {1}, {2}, {3}", n4, n3, n2, n1);
            }
            else if (n4 > n2 & n4 < n3)
            {
                Console.WriteLine("A ordem decrescente é: {0}, {1}, {2}, {3}", n3, n4, n2, n1);
            }
            else if (n4 > n1 & n4 < n2)
            {
                Console.WriteLine("A ordem decrescente é: {0}, {1}, {2}, {3}", n3, n2, n4, n1);
            }
            else if(n4 < n1)
            {
                Console.WriteLine("A ordem decrescente é: {0}, {1}, {2}, {3}", n3, n2, n1, n4);
            }
        }
    }
}
