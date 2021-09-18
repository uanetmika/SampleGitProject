using System;
using System.Collections.Generic;

namespace ConsoleApp49
{
    class information 
    {
        public int id;
        public string namep;
        public string plantd;
        public int nump;
        public string height;
        public string circum;

        public information(int valueid,string valuenamep,string valueplantd,int valuenump,string valueheight,string valuecircum) 
        {
            id = valueid;
            namep = valuenamep;
            plantd = valueplantd;
            nump = valuenump;
            height = valueheight;
            circum = valuecircum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Total Rose : ");
            int totalr = int.Parse(Console.ReadLine());

            Console.Write("Input Total Sun Flower : ");
            int totals = int.Parse(Console.ReadLine());
        }
    }
}
