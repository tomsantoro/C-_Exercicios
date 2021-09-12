using System;

namespace CSharpPratica
{
    class Program
    {
        static void Main(string[] args)
        {
            double  trab_lab, aval_sem, exam_final, media;

            Console.WriteLine("Digite a nota do trabalho de laboratório: ");
            trab_lab = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota da avaliação semestral: ");
            aval_sem = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota do exame final: ");
            exam_final = Convert.ToDouble(Console.ReadLine());

            media = (trab_lab * 2 + aval_sem * 3 + exam_final * 5)/10;
            Console.WriteLine("Média ponderada: " + media);

            if (media >=8 & media <=10)
            {
                Console.WriteLine("Conceito A");
            }
            else if(media >=7 & media < 8)
            {
                Console.WriteLine("Conceito B");
            }
            else if (media >=6 & media <7)
            {
                Console.WriteLine("Conceito C");
            }
            else if (media >=5 & media <6)
            {
                Console.WriteLine("Conceito D");
            }
            else if (media >=0 & media <5)
            {
                Console.WriteLine("Conceito E");
            }
        }
    }
}
