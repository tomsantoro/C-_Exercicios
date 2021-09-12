using System;

namespace CSharpPratica
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int d1, m1, a1, d2, m2, a2;

            Console.WriteLine("Digite a primeira Data: ");

            Console.WriteLine("Digite o dia: ");
            d1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o mês: ");
            m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o ano: ");
            a1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a segunda Data: ");
            d2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o dia: ");
            m2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o mês: ");
            a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o ano: ");
            

            if (a1>a2)
             {
                 Console.WriteLine("A Maior Data:"+ d1+"/"+m1+"/"+a1);
             }
             else if (a2 > a1)
             {
                Console.WriteLine("A Maior Data:" + d2 + "/" + m2 + "/" + a2);
            }
             else if (a1 == a2)
             {
                 if (m1 > m2)
                 {
                    Console.WriteLine("A Maior Data:" + d1 + "/" + m1 + "/" + a1);
                }
                 else if (m2 > m1)
                 {
                    Console.WriteLine("A Maior Data:" + d2 + "/" + m2 + "/" + a2);
                }
                 else if (m2 == m1)
                 {
                     if (d1 > d2)
                     {
                        Console.WriteLine("A Maior Data:" + d1 + "/" + m1 + "/" + a1);
                    }
                     else if (d2 > d1)
                     {
                        Console.WriteLine("A Maior Data:" + d2 + "/" + m2 + "/" + a2);
                    }
                 }
             }
        }
    }
}
