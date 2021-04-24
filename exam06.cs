using System;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            char CHAR;
            int a, b, c;
            Console.Write("input char : ");
            CHAR = char.Parse(Console.ReadLine());
            Console.Write("input number (Step width) : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("input number (Step height) : ");
            b = int.Parse(Console.ReadLine());
            Console.Write("input number (Number of steps) : ");
            c = int.Parse(Console.ReadLine());


            for (int x = 1; x <= c; x++)
            {
                for (int y = 1; y <= b; y++)
                {
                    for (int z = 1; z <= a; z++)
                        Console.Write(CHAR);
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
    }
}
