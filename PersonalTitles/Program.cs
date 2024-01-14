namespace PersonalTitles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // So i have to write a program personal titles 
            // Input age and gender f(female) m(male)
            // If the age are less than 16 Master else Mr.
            // For the female Miss else Ms. 

            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            if (gender == "m")
            {
                if (age < 16)
                {
                    Console.WriteLine("Master");
                }
                else
                {
                    Console.WriteLine("Mr.");
                }
            }
            if (gender == "f")
            {
                if (age < 16)
                {
                    Console.WriteLine("Miss");
                }
                else
                {
                    Console.WriteLine("Ms.");
                }
            }


        }
    }
}
