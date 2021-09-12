using System;

namespace CSharpPratica
{
    class Program
    {
        static void Main(string[] args)
        {
            /*O quilowatt de energia custa um quinto do salario minimo.Receba salario minimo
             e o valor de quilowatts consumido, calcule e mostre:
            - valor de cada quilowatt
            - valor a ser pago 
            - valor a ser pago com desconto de 15%
            */

            double sal_min, qtd_kw, vlr_kw, vlr_reais, desc, vlr_desc;

            Console.WriteLine("Digite o valor do Salario minimo: ");
            sal_min = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de quilowatt consumida: ");
            qtd_kw = Convert.ToDouble(Console.ReadLine());

            vlr_kw = sal_min / 5;
            vlr_reais = vlr_kw * qtd_kw;
            desc = vlr_reais * 15 / 100;
            vlr_desc = vlr_reais - desc;

            Console.WriteLine("Valor do Qwatt: {0}",vlr_kw);
            Console.WriteLine("Valor a ser pago R${0}",vlr_reais);
            Console.WriteLine("Valor a ser pago com desconto R${0}",vlr_desc);


        }
    }
}
