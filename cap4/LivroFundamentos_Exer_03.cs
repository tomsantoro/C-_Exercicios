using System;

namespace CSharpPratica
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2;
            Console.WriteLine("Digite o 1° número: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o 2° número: ");
            n2 = Convert.ToDouble(Console.ReadLine());
            if(n1 > n2)
            {
                Console.WriteLine("Este é o maior: " + n1);
            }
            else if(n2 > n1)
            {
                Console.WriteLine("Esté é o maior: " + n2);
            }
            else
            {
                Console.WriteLine("Os valores são iguais.");
            }
        }
    }
}
