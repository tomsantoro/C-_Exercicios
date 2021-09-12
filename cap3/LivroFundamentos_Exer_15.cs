using System;

namespace CSharpPratica
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Calculando lucro distribuidor, valor dos impostos, preco final do veiculo*/

            double precofabrica, perc_dist, perc_imp, val_dist, val_imp, precofinal;

            Console.WriteLine("Digite o valor de fabrica do veiculo: ");
            precofabrica = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o percentual do distribuidor do veiculo: ");
            perc_dist = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o percentual de imposto do veiculo: ");
            perc_imp = Convert.ToDouble(Console.ReadLine());

            val_dist = precofabrica * (perc_dist / 100);
            val_imp = precofabrica * (perc_imp/100);
            precofinal = precofabrica + val_dist + val_imp;

            Console.WriteLine("O valor do distribuidor é de R${0}",val_dist);
            Console.WriteLine("O valor do imposto é de R${0}", val_imp);
            Console.WriteLine("O valor total que o consumidar pagará é de R${0}",precofinal);

        }
    }
}
