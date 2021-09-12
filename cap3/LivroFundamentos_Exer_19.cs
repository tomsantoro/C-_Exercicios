using System;

namespace CSharpPratica
{
    class Program
    {
        static void Main(string[] args)
        {
            double alt_degrau, alt_alcancar, qtd_degraus;

            Console.WriteLine("Digite a altura do degrau em centimetros: ");
            alt_degrau = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a altura a alcançar em metros: ");
            alt_alcancar = Convert.ToDouble(Console.ReadLine());

            alt_degrau = alt_degrau / 100;
            qtd_degraus = alt_alcancar / alt_degrau;
            Console.WriteLine("Voce deve subir {0} degraus para alcançar {1}m", qtd_degraus, alt_alcancar);

        }
    }
}
