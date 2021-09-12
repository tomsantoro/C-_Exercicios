using System;

namespace CSharpPratica
{
    class Program
    {
        static void Main(string[] args)
        {
            /*receba medida do angulo em graus formada por uma escada apoiada no chao e encostada na parede
             e a altura da parede que está a ponta da escada. calcule e mostre a medida dessa escada
            OBS: Funções trigonométricas emplementadas na linguagens de programação trabalham com medidades
            de angulo em radianos*/

            double angulo, alt_parede, escada, radiano;
            Console.WriteLine("Digite o ângulo: ");
            angulo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a altura da parede:");
            alt_parede = Convert.ToDouble(Console.ReadLine());

            radiano = angulo * 3.14 / 180;
            escada = alt_parede / Math.Sin(radiano);//MAth.Sin = calculando o seno de um numero//
            Console.WriteLine("A medida da escada é de {0}", escada);
        }
    }
}
