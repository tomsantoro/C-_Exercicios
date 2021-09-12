using System;

namespace CSharpPratica
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Receba uma hora formada por hora e minutos(numero real) calcule e mostre a hora digitada
             * apenas em minutos.
            */

            double hora, h, min, conversao;

            Console.WriteLine("Digite a hora atual: ");
            hora = Convert.ToDouble(Console.ReadLine());

            h = Convert.ToInt32(hora);
            min = hora - h;
            conversao = (h * 60) + (min * 100);
            Console.WriteLine("Apenas as horas: " + h);
            Console.WriteLine("Apenas os minutos: "+ min);
            Console.WriteLine("{0} tem {1} minutos", hora, conversao);
        }
    }
}
