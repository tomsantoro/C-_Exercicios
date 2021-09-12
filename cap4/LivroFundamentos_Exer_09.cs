using System;

namespace CSharpPratica
{
    class Program
    {
        static void Main(string[] args)
        {
            string data, horas;
            double dia, mes, ano, h, min;
            Console.WriteLine("Digite a data de hoje(DD/MM/AAAA): ");
            data = Console.ReadLine();
            Console.WriteLine("Digite a hora e minuto(H.MIN):");
            horas = Console.ReadLine();

            string[] dtVetor = data.Split("/");                        
            dia =  Convert.ToInt32(dtVetor[0]);
            mes = Convert.ToInt32(dtVetor[1]);
            ano = Convert.ToInt32(dtVetor[2]);
            string[] hmvetor = horas.Split(".");
            h = Convert.ToInt32(hmvetor[0]);
            min = Convert.ToInt32(hmvetor[1]);

            Console.WriteLine("Data Atual: {0}/{1}/{2}",dia, mes, ano);

            switch (mes)
            {
                case 1:
                    Console.WriteLine("Mês: Janeiro");
                    break;
                case 2:
                    Console.WriteLine("Mês: Fevereiro");
                    break;
                case 3:
                    Console.WriteLine("Mês: Março");
                    break;
                case 4:
                    Console.WriteLine("Mês: Abril");
                    break;
                case 5:
                    Console.WriteLine("Mês: Maio");
                    break;
                case 6:
                    Console.WriteLine("Mês: Junho");
                    break;
                case 7:
                    Console.WriteLine("Mês: Julho");
                    break;
                case 8:
                    Console.WriteLine("Mês: Agosto");
                    break;
                case 9:
                    Console.WriteLine("Mês: Setembro");
                    break;
                case 10:
                    Console.WriteLine("Mês: Outubro");
                    break;
                case 11:
                    Console.WriteLine("Mês: Novembro");
                    break;
                case 12:
                    Console.WriteLine("Mês: Dezembro");
                    break;
            }
            Console.WriteLine("Hora Atual: {0}:{1}min", h, min);
        }
    }
}
