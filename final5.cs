using System;

namespace ConsoleApp36
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("number item : ");
            int num = int.Parse(Console.ReadLine());

            while (num <= 0)
            {
                Console.Write("number item : ");
                num = int.Parse(Console.ReadLine());
            }

            Console.Write("Item : ");
            string item = Console.ReadLine();
            Console.Write("Type : ");
            string type = Console.ReadLine();
            
        }
    }
}
