namespace FruitOrVegetable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // So i have to write a program to follow is it vegetable or fruit 
            // Fruits {banana, apple, kiwi, cherry, lemon и grapes}
            // Vegetable {tomato, cucumber, pepper и carrot}
            // The others are unknown

            string products = Console.ReadLine();

            if (products == "banana" || products == "apple" || products == "kiwi" || products == "cherry" || products == "lemon" || products == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (products == "tomato" || products == "cucumber" || products == "pepper" || products == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
