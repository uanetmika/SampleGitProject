using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int password;
            string org;
            
            Console.Write("Please Input Your Password : ");
            password = int.Parse(Console.ReadLine());
            Console.Write("Please Input Your Organization : ");
            org = Console.ReadLine();

            if (org == "CIA")
            {
                bool check1 = (password - 3) % 10 == 0 || (password - 6) % 10 == 0 ||
                (password - 9) % 10 == 0;

                bool check2 = (password % 100) / 10 != 1 || (password % 100) / 10 != 3 ||
                (password % 100) / 10 != 5;

                bool check3 = (password % 10000) / 1000 >= 6 || (password % 10000) / 1000 != 8;

                bool check4 = check1 && check2 && check3;

                Console.WriteLine(check4);

            }

            else if (org == "FBI")
            {
                bool check1 = (password % 1000000) / 100000 >= 4 && (password % 1000000) / 100000 <= 7;

                bool check2 = (password % 1000) / 100 == 2 || (password % 1000) / 100 == 4 ||
                (password % 1000) / 100 == 8 && (password % 1000) / 100 != 6;

                bool check3 = (password % 100000) / 10000 == 1 || (password % 100000) / 10000 == 3 ||
                (password % 100000) / 10000 == 5 || (password % 100000) / 10000 == 7 || (password % 100000) / 10000 == 9;

                bool check4 = check1 && check2 && check3;

                Console.WriteLine(check4);
            }


            else if (org == "NSA")
            {
                bool check1 = (password % 10) % 30 == 10;

                bool check2 = (password % 10000) % 3 == 0 && (password % 10000) % 2 != 0;

                bool check3 = (password % 10) == 7 || (password % 100) == 7 || (password % 1000) == 7 || (password % 10000) == 7 ||
                (password % 100000) == 7 || (password % 1000000) == 7;

                bool check4 = check1 && check2 && check3;

                Console.WriteLine(check4);
            }

            else
                Console.WriteLine("false");

            

            Console.ReadLine();
        }
    }
}
