using System;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("hangout?(Yes or NO): ");
            string h = Console.ReadLine();

            if (h == "Yes" || h == "yes")
            {
                Console.Write("where to hangout (Silom , Thonglor and Khaosan Road) : ");
                string p = Console.ReadLine();


                if (p == "Silom" || p == "silom")
                {
                    Console.Write("Style (Open air , EDM or Rooftop bar) : ");
                    string s = Console.ReadLine();

                    if (s == "Open air" || s == "open air")
                    {
                        Console.WriteLine("The Balcony");
                        Console.WriteLine("86-88 Silom Soi 4 Silom, Bangrak,Bangkok");
                    }
                    if (s == "EDM" || s == "edm")
                    {
                        Console.WriteLine("The Club At Koi");
                        Console.WriteLine("Sathorn Square Tower , north sathon Road,Silom ,Bangrak ,Bangkok");
                    }
                    if (s == "Rooftop Bar" || s == "rooftop bar" || s == "Rooftop bar")
                    {
                        Console.WriteLine("Trok Silom");
                        Console.WriteLine("36/38 Naradhiwat Rajanagarindra Rd, Silom, Bang Rak, Silom Plaza, 483, Bangkok");
                    }
                }

                if (p == "Thonglor" || p == "thonglor")
                {
                    Console.Write("Style (Open air , EDM or Rooftop bar) : ");
                    string s = Console.ReadLine();

                    if (s == "Open air" || s == "open air")
                    {
                        Console.WriteLine("Tak Sura");
                        Console.WriteLine("Soi Sukhumvit 63 (Soi Ekkamai 8), Sukhumvit Road, Watthana, Bangkok, Khlongtan Nuea");
                    }
                    if (s == "Rooftop Bar" || s == "rooftop bar" || s == "Rooftop bar")
                    {
                        Console.WriteLine("Muse Thonglor");
                        Console.WriteLine("159/8 Soi Thong Lor 10, Sukhumvit Road, Khlong Ton Nuea Subdistrict, Vadhana District., Bangkok Thailand");
                    }
                    if (s == "EDM" || s == "edm")
                    {
                        Console.WriteLine("Safe house");
                        Console.WriteLine("Thonglor Soi 10, 10110 Bangkok");
                    }
                }

                if (p == "Khaosan Road" || p == "khaosan road")
                {
                    Console.Write("Style (Open air , EDM or Rooftop bar) : ");
                    string s = Console.ReadLine();

                    if (s == "Open air" || s == "open air")
                    {
                        Console.WriteLine("Fu Bar");
                        Console.WriteLine("72/1-5 Soi Rambutree, Taladyod, Pranakorn");
                    }
                    if (s == "Rooftop Bar" || s == "rooftop bar" || s == "Rooftop bar")
                    {
                        Console.WriteLine("At mosphere rooftop café");
                        Console.WriteLine("113/1 Thanon Tani");
                    }
                    if (s == "EDM" || s == "edm")
                    {
                        Console.WriteLine("The Club");
                        Console.WriteLine("Khaosan Road, 10200 Bangkok");
                    }
                }


            }
            else if (h == "NO" || h == "no") 
            {
                Console.Write("Go to Home!");
            }
               

            Console.ReadLine();

        }
    }
}
