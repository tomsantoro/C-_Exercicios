using System;

namespace CSharpPratica
{
    class Program
    {
        static void Main(string[] args)
        {
            /* receba o custo de um espetaculo, proço do convite desse espetaculo
               calcule e mostre a quantidade de ingressos que precisam ser vendidos
               para alcançar o custo do espetaculo 
             */

            double custo, vlr_ing, qtd_ingressos;

            Console.WriteLine("Digite o custo do espetáculo: ");
            custo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do ingresso: ");
            vlr_ing = Convert.ToDouble(Console.ReadLine());

            qtd_ingressos = custo / vlr_ing;

            Console.WriteLine("Serão necessárias vender {0} ingressos", qtd_ingressos);

        }
    }
}
