using System;

namespace CSharpPratica
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, a, b, c;
            Console.WriteLine("Digite o valor de A:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de B:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de C:");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de X (apenas 1, 2 ou 3): ");
            x = Convert.ToDouble(Console.ReadLine());

            if(x == 1){
                
                if(a < b & a < c){
                    
                    if (b < c){
                        Console.WriteLine("{0}, {1}, {2}", a, b, c);
                    }
                    else{
                        Console.WriteLine("{0}, {1}, {2}", a, c, b);
                    }
                }
                else if (b < a & b < c){
                    
                    if (a < c){
                        Console.WriteLine("{0}, {1}, {2}", b, a, c);
                    }
                    else{
                        Console.WriteLine("{0}, {1}, {2}", b, c, a);
                    }
                }
                else if(c < a & c < b ){
                    if (a < b){
                        Console.WriteLine("{0}, {1}, {2}", c, a, b);
                    }
                    else{
                        Console.WriteLine("{0}, {1}, {2}", c, b, a);
                    }
                }
            }
            else if (x==2){ 
                
                if(a > b & a > c){
                    
                    if (b > c){
                        Console.WriteLine("{0}, {1}, {2}", a, b, c);
                    }
                    else{
                        Console.WriteLine("{0}, {1}, {2}", a, c, b);
                    }
                }
                else if (b > a & b > c){

                    if (a > c){
                        Console.WriteLine("{0}, {1}, {2}", b, a, c);
                    }
                    else{
                        Console.WriteLine("{0}, {1}, {2}", b, c, a);
                    }
                }
                else if (c > a & c > b){

                    if (a > b){
                        Console.WriteLine("{0}, {1}, {2}", c, a, b);
                    }
                    else{
                        Console.WriteLine("{0}, {1}, {2}", c, b, a);
                    }
                }
            }
            else if (x==3){

                if(a > b & a > c){
                    Console.WriteLine("{0}, {1}, {2}", b, a, c);
                }
                else if(b > a & b > c){
                    Console.WriteLine("{0}, {1}, {2}", a, b, c);
                }
                else if(c > a & c > b){
                    Console.WriteLine("{0}, {1}, {2}", a, c, b);
                }
            }
            
        }
    }
}
