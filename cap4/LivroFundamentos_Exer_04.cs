using System;

namespace CSharpPratica
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3;
            Console.WriteLine("Digite o primeiro número:");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número:");
            n3 = Convert.ToDouble(Console.ReadLine());

            if(n1 < n2 & n1 < n3)
            {
                if(n2 < n3)
                {
                    Console.WriteLine("A ordem crescente é: {0}, {1}, {2}", n1, n2, n3);
                    
                }
                else
                {
                    Console.WriteLine("A ordem crescente é: {0}, {1}, {2}", n1, n3, n2);
                }
            }
            else if(n2 < n1 & n2 < n3)
            {
                if (n1 < n3)
                {
                    Console.WriteLine("A ordem crescente é: {0}, {1}, {2}", n2, n1, n3);
                }
                else
                {
                    Console.WriteLine("A ordem crescente é: {0}, {1}, {2}", n2, n3, n1);
                }
            }          
            else if (n3 < n1 & n3 < n2)
            {
                if (n1 < n2)
                {
                    Console.WriteLine("A ordem crescente é: {0}, {1}, {2}", n3, n1, n2);
                }
                else
                {
                    Console.WriteLine("A ordem crescente é: {0}, {1}, {2}", n3, n2, n1);
                }
            }

        }
    }
}
