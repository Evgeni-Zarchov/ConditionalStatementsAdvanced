using System.Runtime.InteropServices;

namespace SmallShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // So i have to write a program for shop business
            // Input product, city, quantity
            // city coffee water beer sweets peanuts
            // Sofia 0.50 0.80 1.20 1.45 1.60
            // Plovdiv 0.40 0.70 1.15 1.30 1.50
            // Varna 0.45 0.70 1.10 1.35 1.55

            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;

            if (city == "Sofia")
            {
                if (product == "coffee")
                    price = quantity * 0.50;
                else if (product == "water")
                    price = quantity * 0.80;
                else if (product == "beer")
                    price = quantity * 1.20;
                else if (product == "sweets")
                    price = quantity * 1.45;
                else if (product == "peanuts")
                    price = quantity * 1.60;
            }
            if (city == "Plovdiv")
            {
                if (product == "coffee")
                    price = quantity * 0.40;
                else if (product == "water")
                    price = quantity * 0.70;
                else if (product == "beer")
                    price = quantity * 1.15;
                else if (product == "sweets")
                    price = quantity * 1.30;
                else if (product == "peanuts")
                    price = quantity * 1.50;
            }
            if (city == "Varna")
            {
                if (product == "coffee")
                    price = quantity * 0.45;
                else if (product == "water")
                    price = quantity * 0.70;
                else if (product == "beer")
                    price = quantity * 1.10;
                else if (product == "sweets")
                    price = quantity * 1.35;
                else if (product == "peanuts")
                    price = quantity * 1.55;
            }
            Console.WriteLine(price);

        }
    }
}
