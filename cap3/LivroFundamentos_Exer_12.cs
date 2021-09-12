using System;

namespace CSharpPratica
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, r1, r2;
            Console.WriteLine("Digite o 1ª numero: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o 2ª numero: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            r1 = Math.Pow(n1, n2);
            r2 = Math.Pow(n2, n1);

            Console.WriteLine("O número {0} elevado ao número {1} é = {2}",n1,n2,r1);
            Console.WriteLine("O número {0} elevado ao número {1} é = {2}",n2,n1,r2);
        }
    }
}