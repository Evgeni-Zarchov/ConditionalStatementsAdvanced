namespace WorkingHours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // so i have ti write a program working time 
            // working days are from Monday-Saturday inclusive

            int workingHours = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday" || day == "Saturday")
            {
                if (workingHours >= 10 && workingHours <= 18)
                {
                    Console.WriteLine("open");
                }
                else
                {
                    Console.WriteLine("closed");
                }
            }
            else if (day == "Sunday")
            {
                Console.WriteLine("closed");
            }
            else
            {
                Console.WriteLine("closed");
            }

        }
    }
}
