using System.ComponentModel.Design;

namespace FruitShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // So i have to write program fruit shop but the shop on working day working on some price
            // But the weekend works with higher price 

            string products = Console.ReadLine();
            string dayOfWeeks = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());


            if (dayOfWeeks == "Monday" || dayOfWeeks == "Tuesday" || dayOfWeeks == "Wednesday" || dayOfWeeks == "Thursday" || dayOfWeeks == "Friday")
            {
                if (products == "banana")
                {
                    Console.WriteLine("{0:F2}", quantity * 2.50);
                }
                else if (products == "apple")
                {
                    Console.WriteLine("{0:F2}", quantity * 1.20);
                }
                else if (products == "orange")
                {
                    Console.WriteLine("{0:F2}", quantity * 0.85);
                }
                else if (products == "grapefruit")
                {
                    Console.WriteLine("{0:F2}", quantity * 1.45);
                }
                else if (products == "kiwi")
                {
                    Console.WriteLine("{0:F2}", quantity * 2.70);
                }
                else if (products == "pineapple")
                {
                    Console.WriteLine("{0:F2}", quantity * 5.50);
                }
                else if (products == "grapes")
                {
                    Console.WriteLine("{0:F2}", quantity * 3.85);
                }
                else
                {
                    Console.WriteLine("error");
                }

            }
            else if (dayOfWeeks == "Saturday" || dayOfWeeks == "Sunday")
            {
                if (products == "banana")
                {
                    Console.WriteLine("{0:F2}", quantity * 2.70);
                }
                else if (products == "apple")
                {
                    Console.WriteLine("{0:F2}", quantity * 1.25);
                }
                else if (products == "orange")
                {
                    Console.WriteLine("{0:F2}", quantity * 0.90);
                }
                else if (products == "grapefruit")
                {
                    Console.WriteLine("{0:F2}", quantity * 1.60);
                }
                else if (products == "kiwi")
                {
                    Console.WriteLine("{0:F2}", quantity * 3);
                }
                else if (products == "pineapple")
                {
                    Console.WriteLine("{0:F2}", quantity * 5.60);
                }
                else if (products == "grapes")
                {
                    Console.WriteLine("{0:F2}", quantity * 4.20);
                }
                else
                {
                    Console.WriteLine("error");
                }

            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }



}
