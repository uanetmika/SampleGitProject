using System;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("pls input number a : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("pls input number b : ");
            int b = int.Parse(Console.ReadLine());

            int x = a;
            int y = b;

            do
            {
                if (x < y)
                {
                    x = x + a;
                }
                else
                {
                    y = y + b;
                }
            }
            while (x != y);
            {
                Console.Write(x);
            }

            Console.ReadLine();

        }

    } 

    
}
