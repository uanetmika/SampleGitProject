using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            bool game = true;
            Console.Write("Pls input number box 1 : ");
            int box1 = int.Parse(Console.ReadLine());
            Console.Write("Pls input number box 2 : ");
            int box2 = int.Parse(Console.ReadLine());
            Console.Write("Pls input number box 3 : ");
            int box3 = int.Parse(Console.ReadLine());


            while (game == true)
            {
                Console.Write("PlayerA : Choose box 1 , 2 or 3 : ");
                int ab = int.Parse(Console.ReadLine());
                Console.Write("PlayerA choose number 1 , 2 or 3 : ");
                int n = int.Parse(Console.ReadLine());
                switch (ab)
                {
                    case 1:
                        box1 = box1 - n;
                        break;
                    case 2:
                        box2 = box2 - n;
                        break;
                    case 3:
                        box3 = box3 - n;
                        break;
                    default:
                        Console.WriteLine("Try again");
                        break;
                }

                if (box1 <= 0 & box2 <= 0 & box3 <= 0)
                {
                    Console.WriteLine("PlayerB Win!");
                    game = false;
                    return;
                }
                Console.Write("Player B : Choose box 1 , 2 or 3 : ");
                int bb = int.Parse(Console.ReadLine());
                Console.Write("PlayerB choose number 1 , 2 or 3 : ");
                int nb = int.Parse(Console.ReadLine());
                switch (bb)
                {
                    case 1:
                        box1 = box1 - nb;
                        break;
                    case 2:
                        box2 = box2 - nb;
                        break;
                    case 3:
                        box3 = box3 - nb;
                        break;
                    default:
                        Console.WriteLine("Try again");
                        break;
                }
                if (box1 <= 0 & box2 <= 0 & box3 <= 0)
                {
                    Console.WriteLine("PlayerA Win!");
                    game = false;
                    return;
                }
            }
        }
    }
}
