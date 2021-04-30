using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows, a = 1, b, i, j;
            Console.Write("Pls input number of rows : ");
            rows = int.Parse(Console.ReadLine());

            while (rows < 0)
            {
                Console.WriteLine("Invalid Pascal's triangle row number.");
                Console.Write("Pls input number of rows : ");
                rows = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < rows; i++)
            {
                for (b = 1; b <= rows - i; b++)
                    Console.Write("");
                for (j = 0; j <= i; j++)
                {
                    if (j == 0 || i == 0)
                        a = 1;
                    else
                        a = a * (i - j + 1) / j;
                    Console.Write(a + " ");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
