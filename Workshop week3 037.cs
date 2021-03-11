using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            double P, T ;
            Console.Write("Pls Input time or price : ");
            string O = Console.ReadLine();
            double X = double.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine()); //ให้เพื่อนสอนค่า5555

            if (O == "time" || O == "price")
            {
                if (X > 0)
                {
                    if (O == "time")
                    {
                        P = Math.Pow(X - 1, 2);
                        Console.Write(X);
                        Console.Write(P);
                    }
                }

                if (O == "price")
                {
                    if (X < 1 && Y < 1)
                    {
                        T = 1 - Math.Sqrt(Y);
                        Console.Write(T);
                        Console.Write(Y);
                    }
                    else
                    {
                        T = 1 + Math.Sqrt(Y);
                        Console.Write(T);
                        Console.Write(Y);
                    }
                }
                else
                {
                    Console.Write("Invalid mouse position");
                }
            }
                else 
                {
                Console.Write("Invalid mode");            
                }

            Console.ReadLine();
        }
    }
}
