using System;

namespace CSharpPratica
{
    class Program
    {
        static void Main(string[] args)
        {
            /*faca um programa para calc e mostrar a que distancia a escada deve estar da parede, para ser
             pregado um quadro - Receba o tamanho da escada e a altura em que deseja pregar o quadro
            lembre-se que a altura da escada deve ser maior do que a altura que se deseja alcançar*/

            double alt_quadro, escada, distancia;
            Console.WriteLine("Digite o tamanho da escada: ");
            escada = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o tamanho que desejar pregar o quadro:");
            alt_quadro = Convert.ToDouble(Console.ReadLine());
            
            //Usar a formula do teorema de pitagoras para calcular a distancia

            distancia = Math.Pow(escada, 2) - Math.Pow(alt_quadro, 2);
            distancia = Math.Sqrt(distancia);
            Console.WriteLine("Distancia que a escada deve estar da parede é de: "+distancia);

        }
    }
}
