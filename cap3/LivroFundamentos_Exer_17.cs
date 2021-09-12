using System;

namespace CSharpPratica
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, cheque1, cheque2, cpmf1, cpmf2, saldoatual;

            Console.WriteLine("Digite o valor so salário: ");
            salario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do cheque1: ");
            cheque1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do cheque2: ");
            cheque2 = Convert.ToDouble(Console.ReadLine());
            
            /*Calculos cpfm 0,38%*/
            cpmf1 = cheque1 * 0.38 / 100;
            cpmf2 = cheque2 * 0.38 / 100;
            saldoatual = salario - cheque1 - cheque2 - cpmf1 - cpmf2;
            /*output*/
            Console.WriteLine("Seu saldo atual é de R${0}",saldoatual);
            
        }
    }
}
