namespace ch3_change_calc_bythebook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Change Calculator");

            string choice = "y";
            while (choice == "y")
            {
                Console.WriteLine("Enter Number of cents (0-99)");
                int cents = Int32.Parse(Console.ReadLine());
                int quarters = cents / 25;
                cents = cents % 25;
                int dimes = cents / 10;
                cents %= 10;
                int nickels = cents / 5;
                cents %= 5; 
                int pennies = cents / 1;
                Console.WriteLine();
                Console.WriteLine("Quarters: " + quarters);
                Console.WriteLine("Dimes: " + dimes);
                Console.WriteLine("Nickels : " + nickels);
                Console.WriteLine("Pennies: " + pennies);
                

                Console.WriteLine("Continue? y/n");
                choice = Console.ReadLine().ToLower();
            }
            Console.WriteLine("Goodbye");
        }
    }
}
