using System;

namespace CSharpPratica
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            double quad, cubo, r2, r3;
            Console.WriteLine("Digite um número inteiro e positivo: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num>0)
            {
                quad = Math.Pow(num,2);
                cubo = Math.Pow(num,3);
                r2 = Math.Sqrt(num);
                r3 = Math.Cbrt(num);
                Console.WriteLine("Quadrado = {0} /n Cubo = {1} /n Raiz Quadrada = {2} /n Raiz Cubica = {3}", quad, cubo, r2, r3);
            }
            else
            {
                Console.WriteLine("O número digitado deve ser inteiro e positivo.");
            }
            
        }
    }
}