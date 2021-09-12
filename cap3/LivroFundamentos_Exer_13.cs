using System;

namespace CSharpPratica
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1 pé = 12 polegadas
               1 jarda = 3 pés  
               1 milha = 1760 jardas;
            */
            double pes, polegadas, jardas, milhas;
            
            Console.WriteLine("Digita um valor de medida em Pés: ");
            pes = Convert.ToDouble(Console.ReadLine());
            
            polegadas = pes * 12;
            jardas = pes / 3;
            milhas = jardas/1760;

            Console.WriteLine("Pés = {0} Polegadas = {1} Jardas = {2} Milhas = {3}",pes,polegadas,jardas,milhas);
        }
    }