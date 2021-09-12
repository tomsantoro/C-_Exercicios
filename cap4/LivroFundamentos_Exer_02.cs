using System;

namespace CSharpPratica
{
    class Program
    {
        static void Main(string[] args)
        {
            double  n1, n2, n3, media, exame;
            Console.WriteLine("Digite a 1° nota: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a 2° nota: ");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a 3° nota: ");
            n3 = Convert.ToDouble(Console.ReadLine());

            media = (n1 + n2 + n3) / 3;
            Console.WriteLine("Média = " + media);
            if(media>=0 & media < 3)
            {
                Console.WriteLine("Reprovado.");
            }
            else if(media >=3 & media < 7)
            {
                exame = 12 - media;
                Console.WriteLine("Exame de Recuperação, você precisa tirar {0}",exame);
            }
            else
            {
                Console.WriteLine("Aprovado");
            }
        }
    }
}
