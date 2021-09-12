using System;

namespace CSharpPratica
{
    class Program
    {
        static void Main(string[] args)
        {
            /*** cod 1 = 50% aumento || cod 2 = 35% || cod 3 =20% || cod 4 = 10% ||
             *   cod 5 = sem aumento    
             ***/
            int cod;
            double aumento, sal, sal_new;
            string cargo;

            Console.WriteLine("Digite o Código do funcionário(de 1 a 5):");
            int.TryParse(Console.ReadLine(), out cod);                      
            
            if (cod == 1)
            {
                Console.WriteLine("Digite o Valor do Salário: ");
                double.TryParse(Console.ReadLine(), out sal);
                aumento = sal * 50 / 100;
                sal_new = sal + aumento;
                Console.WriteLine("O cargo é Escrituário.");
                Console.WriteLine($"O valor de aumento é de R${aumento}");
                Console.WriteLine($"O novo salário é de R${sal_new}");
            }
            else if (cod == 2)
            {
                Console.WriteLine("Digite o Valor do Salário: ");
                double.TryParse(Console.ReadLine(), out sal);
                aumento = sal * 35 / 100;
                sal_new = sal + aumento;
                Console.WriteLine("O cargo é Secretário(a).");
                Console.WriteLine($"O valor de aumento é de R${aumento}");
                Console.WriteLine($"O novo salário é de R${sal_new}");
            }
            else if (cod == 3)
            {
                Console.WriteLine("Digite o Valor do Salário: ");
                double.TryParse(Console.ReadLine(), out sal);
                aumento = sal * 20 / 100;
                sal_new = sal + aumento;
                Console.WriteLine("O cargo é Caixa.");
                Console.WriteLine($"O valor de aumento é de R${aumento}");
                Console.WriteLine($"O novo salário é de R${sal_new}");
            }
            else if (cod == 4)
            {
                Console.WriteLine("Digite o Valor do Salário: ");
                double.TryParse(Console.ReadLine(), out sal);
                aumento = sal * 10 / 100;
                sal_new = sal + aumento;
                Console.WriteLine("O cargo é Gerente.");
                Console.WriteLine($"O valor de aumento é de R${aumento}");
                Console.WriteLine($"O novo salário é de R${sal_new}");
            }
            else if (cod == 5)
            {
                Console.WriteLine("Digite o Valor do Salário: ");
                double.TryParse(Console.ReadLine(), out sal);
                aumento = sal * 0 / 100;
                sal_new = sal + aumento;
                Console.WriteLine("O cargo é Diretor.");
                Console.WriteLine($"O valor de aumento é de R${aumento}");
                Console.WriteLine($"O novo salário é de R${sal_new}");
            }
            else
            {
                Console.WriteLine("Cargo inexistente.");
            }

        }
    }
}
