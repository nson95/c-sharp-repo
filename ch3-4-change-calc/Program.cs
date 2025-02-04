namespace ch3_4_change_calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Change Calculator");

            string choice = "y";
            while (choice == "y")
            {
                int quarters = 0;
                int dimes = 0;
                int nickels = 0;
                int pennies = 0;
                Console.Write("Enter number of cents (0-99) ");
                int totalChange = Convert.ToInt32(Console.ReadLine());
                while (totalChange > 0)
                {
                    if (totalChange >= 25)
                    {
                        quarters++;
                        totalChange -= -25;
                    }
                    else if (totalChange >= 10)
                    {
                        dimes++;
                        totalChange -= 10;
                    }
                    else if (totalChange >= 5)
                    {
                        nickels++;
                        totalChange -= 5;
                    }
                    else if (totalChange >= 1)
                    {
                        pennies++;
                        totalChange -= 1;
                    }
                        Console.WriteLine();
                        Console.WriteLine("Quarters: " + quarters);
                        Console.WriteLine("Dimes: " + dimes);
                        Console.WriteLine("Nickels : " + nickels);
                        Console.WriteLine("Pennies: " + pennies);
                    
                    // may be need done with array
                    pennies = 0;
                    nickels = 0;
                    dimes = 0;
                    quarters = 0;
                }
            }
                Console.WriteLine("Continue? y/n");
                choice = Console.ReadLine().ToLower();

        }
    }
}
