using System.Data;

namespace Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // So i have to write a program for cinema ticket
            // So i have to count bcs the task is giving row and column i have to calc to know how much place will have the room 
            // Premier ticket is 12$, Normal is 7.50$, Discount 5$

            string ticketType = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());

            double seats = row * column;

            double ticketsPrice = 0;

            // I will use switch case in switch case i can't use boolean it works only with exact amount

            switch (ticketType)
            {
                case "Premiere":
                    ticketsPrice = 12;
                    break;
                case "Normal":
                    ticketsPrice = 7.50;
                    break;
                case "Discount":
                    ticketsPrice = 5;
                    break;
            }

            double totalPrice = ticketsPrice * seats;

            Console.WriteLine("{0:F2} leva", totalPrice);

        }
    }
}
