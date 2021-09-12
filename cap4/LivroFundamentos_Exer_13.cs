 using System;

namespace CSharpPratica
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            double sal, aumento, n_sal, imp;
            Console.WriteLine("Menu de Opções: ");
            Console.WriteLine("1 - Imposto");
            Console.WriteLine("2 - Novo Salário");
            Console.WriteLine("3 - Classificação");
            Console.WriteLine("Digite a Opção Desejada: ");
            int.TryParse(Console.ReadLine(), out op);

            if (op == 1)
            {
                Console.WriteLine("Digite o salário do funcionário: ");
                double.TryParse(Console.ReadLine(), out sal);
                if(sal < 500)
                {
                    imp = sal * 5 / 100;
                }
                else if (sal >= 500 && sal <= 850)
                {
                    imp = sal * 10 / 100;
                }
                else
                {
                    imp = sal * 15 / 100;
                }
                Console.WriteLine($"Imposto de {imp}");
;            }
            else if (op == 2)
            {
                Console.WriteLine("Digite o salário do funcionário: ");
                double.TryParse(Console.ReadLine(), out sal);
                if(sal > 1500)
                {
                    n_sal = sal + 25.00; 
                }
                else if(sal >= 750 && sal <= 1500)
                {
                    n_sal = sal + 50.00;
                }
                else if (sal >= 450 && sal < 750)
                {
                    n_sal = sal + 75.00;
                }
                else
                {
                    n_sal = sal + 100.00;
                }
                Console.WriteLine($"Novo Salário é de R${n_sal}");
            }
            else if(op == 3)
            {
                Console.WriteLine("Digite o salário do funcionário: ");
                double.TryParse(Console.ReadLine(), out sal);
                if(sal <= 700)
                {
                    Console.WriteLine("Mal Remunerado.");
                }
                else
                {
                    Console.WriteLine("Bem Remunerado.");
                }
            }
        }
    }
}
