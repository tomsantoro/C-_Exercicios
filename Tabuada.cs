using System;

namespace CSharpPratica
{
    class Program
    {
        static void Main(string[] args)
        {
            int x,num,i;
            Console.WriteLine("Digite o número para obter a sua tabuada:");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("========Tabuada de {0}============",num);
            for (i=1; i <=10; i++)
            {
                x = num * i;
                Console.WriteLine("{0} x {1} = {2}", num, i, x);
            }

            Console.ReadKey();
        }
    }
}
