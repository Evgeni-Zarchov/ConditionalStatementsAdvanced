namespace DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // So i have to write a program day of week 
            // 1-7 if the day is over 7 Error
            // I will use switch case

            int dayOfWeek = int.Parse(Console.ReadLine());

            switch (dayOfWeek)
            {
                case 1: Console.WriteLine("Monday"); break;
                case 2: Console.WriteLine("Tuesday"); break;
                case 3: Console.WriteLine("Wednesday"); break;
                case 4: Console.WriteLine("Thursday"); break;
                case 5: Console.WriteLine("Friday"); break;
                case 6: Console.WriteLine("Saturday"); break;
                case 7: Console.WriteLine("Sunday"); break;
                default: Console.WriteLine("Error"); break;
            }

        }
    }
}
