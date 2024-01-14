namespace WeekendOrWorkingDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // So i have the task to write a weekend or working day 
            // So the working days are from Monday-Friday
            // Weekend Saturday-Sunday
            // i will use switch case bcs is easy and faster way

            string day = Console.ReadLine();

            switch (day)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    Console.WriteLine("Working day");
                    break;
                case "Saturday":
                case "Sunday":
                    Console.WriteLine("Weekend");
                    break;
                default: 
                    Console.WriteLine("Error");
                    break;

            }
        }
    }
}
