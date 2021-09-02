using System;
using System.Collections.Generic;

namespace ConsoleApp46
{
    class User
    {
        public string Name, Email;
        private List<Tshirt> Order;
        private List<Address> Location;

        public User (string valueName, string valueEmail) 
        {
            Name = valueName;
            Email = valueEmail;
            Order = new List<Tshirt>();
            Location = new List<Address>();
        }

        public void ts(Tshirt tshirt) 
        {
            Order.Add(tshirt);
        }

        public void ad(Address address) 
        {
            Location.Add(address);
        }
        public void sent()
        {
            Console.WriteLine("User_Name : {0}", this.Name);
            Console.WriteLine("User_E-mail : {0}", this.Email);
        }
    }
    class Address 
    {
        public string Street,City,Zipcode;

        public Address(String valueStreet, String valueCity, String valueZipcode) 
        {
            Street = valueStreet;
            City = valueCity;
            Zipcode = valueZipcode;
        }

        public void output1() 
        {
            Console.WriteLine("Address : 131 / 75 Street {0},City  {1}, Zipcode  {2}", this.Street, this.City, this.Zipcode);
        }
    }
    class Shoppingcart 
    {
        public List<Tshirt> shirt;
        public List<Address> addresses;

        public  Shoppingcart() 
        {
            shirt = new List<Tshirt>();
            addresses = new List<Address>(); 
             
        }
    }
    class Tshirt 
    {
        public string Size,Color,image;
        public float Price;

        public Tshirt(string valueSize, string valueColor, string valueImage, float valuePrice) 
        {
            Size = valueSize;
            Color = valueColor;
            image = valueImage;
            Price = valuePrice;
        }

        public void output()
        {
            Console.WriteLine("Size : {0} ", this.Size);
            Console.WriteLine("Color : {0} ", this.Color);
            Console.WriteLine("Image : {0} ", this.image);
            Console.WriteLine("Price : {0}", this.Price);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User all = new User("Jame Watson","jame@gmail.com");
            Tshirt shirt1 = new Tshirt("S", "Yellow", "King of Thailand", 625f);
            Tshirt shirt2 = new Tshirt("M", "Black", "DEAD", 750f);
            Tshirt shirt3 = new Tshirt("L", "Red", "Fire", 500f);
            Address lo = new Address("Phutthamonthon","Nakon Pathom","10180");

            all.sent();
            all.ad(lo);
            lo.output1();
            all.ts(shirt1);
            all.ts(shirt2);
            all.ts(shirt3);
            shirt1.output();
            shirt2.output();
            shirt3.output();
            Console.WriteLine("Total Cost : {0} Bath", shirt1.Price + shirt2.Price + shirt3.Price);

            Console.ReadLine();
        }
    }
    
 
}
