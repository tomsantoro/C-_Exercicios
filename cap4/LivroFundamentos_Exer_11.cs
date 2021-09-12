using System;

namespace CSharpPratica
{
    class Program
    {
        static void Main(string[] args)
        {
            int hora_i, min_i, hora_f, min_f, tmp_i, tmp_f;
            double duracao_h, duracao_min;

            Console.WriteLine("Digite a hora inicial do jogo: ");
            Console.WriteLine("Digite a hora: ");
            hora_i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite os minutos :");
            min_i = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a hora final do jogo: ");
            Console.WriteLine("Digite a hora: ");
            hora_f = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite os minutos: ");
            min_f = Convert.ToInt32(Console.ReadLine());

            //1 dia = 24h / 1h = 60min / 1dia tem 1440 min (24x60=1440)
            //calculando a duracao em minutos
            if (min_i > min_f)
            {
                min_f = min_f + 60;
                hora_f = hora_f - 1;
            }
            //calculando a duracao em horas
            //se a hora inicial for maior que a final, passou de 24h a duracao da partida
            //entao soma 24 a hora final e subtrai pela hora inicial
            if(hora_i > hora_f)
            {
                hora_f = hora_f + 24;
            }
            duracao_h = hora_f - hora_i;
            duracao_min = min_f - min_i;

            Console.WriteLine("O jogo durou: " + duracao_h + "horas e " + duracao_min + " minutos");

        }
    }
}
