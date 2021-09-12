using System;

namespace CSharpPratica
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Receba um numero real encontre e mostre:
             - parte inteira desse numero
             - parte fracionaria
             - arredondamento do mesmo
            */

            double num, inteiro, fracao, arredon;

            Console.WriteLine("Digite um número real: ");
            num = Convert.ToDouble(Console.ReadLine());

            inteiro = Convert.ToInt32(num);
            fracao = num - inteiro;
            arredon = Math.Round(num);

            Console.WriteLine("Número: " + num);
            Console.WriteLine("Inteiro: " + inteiro);
            Console.WriteLine("Fração: " + fracao);
            Console.WriteLine("Arredondando: " + arredon);

        }
    }
}
