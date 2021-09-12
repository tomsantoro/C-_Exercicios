using System;

namespace CSharpPratica
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso_saco, qtd_gato1, qtd_gato2, total_rac_fim;

            Console.WriteLine("Digite o peso do saco: ");
            peso_saco = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a quantidade do gato1: ");
            qtd_gato1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a quantidade do gato2: ");
            qtd_gato2 = Convert.ToDouble(Console.ReadLine());

            qtd_gato1 = qtd_gato1 / 1000;
            qtd_gato2 = qtd_gato2 / 1000;

            total_rac_fim = peso_saco - 5 * (qtd_gato1 + qtd_gato2);

            Console.WriteLine("A quantidade que sobrou no fim de 5 dias foi de: {0}kg ",total_rac_fim);

        }
    }
}
