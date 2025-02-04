namespace ch3_proj1_temp_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Temperature Converter");
            string choice = "y";
            while (choice == "y")
            {
                Console.Write("Enter degrees in Fahrenheit: ");
                double degreesF = Convert.ToDouble(Console.ReadLine());
                double degreesC = (degreesF - 32) * 5 / 9;
                degreesC = Math.Truncate(degreesC * 100) / 100;
                Console.WriteLine("Degrees in Celcius: " +degreesC);
                Console.WriteLine("Continue? y/n");
                choice = Console.ReadLine();
            }
            Console.WriteLine("Goodbye");
        }
    }
}
