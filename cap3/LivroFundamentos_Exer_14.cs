using System;

namespace CSharpPratica
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Calculando idade*/

            int AnoNasc, AnoAtual, idade, idade2;
            Console.WriteLine("Digite o ano que nasceu: ");
            AnoNasc = Convert.ToInt32(Console.ReadLine());
            AnoAtual = 2021;
            idade = AnoAtual - AnoNasc;
            idade2 = 2050 - AnoNasc;

            Console.WriteLine("Você tem {0} anos e terá {1} anos em 2050", idade, idade2);

        }
    }
}