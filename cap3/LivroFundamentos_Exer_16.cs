using System;

namespace CSharpPratica
{
    class Program
    {
        static void Main(string[] args)
        {
            /* receba numero de horas trabalhas, valor salario minimo, calcule e mostre o valor
             * do salario a receber, com essas regras:
             * hora trabalhada vale metade do sal minimo
             * sal bruto equivale ao n de horas trabalhadas multiplicado pelo valor da hora trabalhada
             * imposto equivale 3% do sal bruto
             * salario a receber equivale ao sal bruno menos imposto
             */

            double horas_t, val_sal_min, sal_receber, s_bruto, val_h_trab, imposto;

            Console.WriteLine("Digite o valor de horas trabalhadas: ");
            horas_t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do salario minimo: ");
            val_sal_min = Convert.ToDouble(Console.ReadLine());

            val_h_trab = val_sal_min / 2;
            s_bruto = horas_t * val_h_trab;
            imposto = s_bruto * 3 / 100;
            sal_receber = s_bruto - imposto;

            Console.WriteLine("Seu Salário é de R${0}",sal_receber);

        }
    }
}
