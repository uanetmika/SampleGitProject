using System;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            string mode;
            double flimblackwidth, flenght, fov;
            mode = Console.ReadLine();
            flimblackwidth = double.Parse(Console.ReadLine());

            if (flimblackwidth > 0)
            {
               

                if (mode == "flenght")
                {
                    flenght = double.Parse(Console.ReadLine());
                    if (flenght > 0)
                    {
                        fov = 2 * Math.Atan(flimblackwidth / (2 * flenght));
                        Console.WriteLine("flenght={0}", flenght);
                        Console.WriteLine("fov={1}", fov);
                    }
                    else
                    {
                        Console.WriteLine("Invalid flenght Please input again ");

                    }
                }
                else if (mode == "fov")
                {
                    fov = double.Parse(Console.ReadLine());
                    if (fov > 0.1 && fov < 6.28)
                    {
                        flenght = flimblackwidth / (2 * Math.Tan(fov / 2));
                        Console.WriteLine("flenght={0}", flenght);
                        Console.WriteLine("fov={1}", fov);
                    }
                    else
                    {
                        Console.WriteLine("Invalid fov Please input again ");
                    }
                }

            }
            else
            {
                Console.WriteLine("Invalid blackflim width please try again");
            }
        }
    }
}
