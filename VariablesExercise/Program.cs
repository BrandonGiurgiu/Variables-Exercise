namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Declare & Initilize 
            string name = "Brandon";
            int age = 29;
            char middleInitial = 'P';
            bool isOver18 = true;
            double curretTemp = 77.9;
            decimal currentPrice = 29.99m;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Middle Initial: {middleInitial}");
            Console.WriteLine($"Over 18?: {isOver18}");
            Console.WriteLine($"Curret Temperature: {curretTemp}");
            Console.WriteLine($"Current Price: {currentPrice}");

        }
    }
}
