namespace demo2_6_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long nbr = 0;
            string choice = "y";
            Console.WriteLine("Factorial Calc p2");
            while (choice == "y")
            {
                nbr = GetLong("Enter an integer thats greater than 0 and less than 10. ", 1, 9);

                long res = 1;
                for (int i = 1; i <= nbr; i++)
                {
                    res *= i;
                }

                Console.WriteLine(("The factorial of " + nbr + " is " + res));
                Console.Write("Continue? y/n ");
                choice = Console.ReadLine().ToLower();
            }



            Console.WriteLine("Goodbye");
        }
        private static long GetLong(string prompt, long min, long max)
        {
            long res = 0;
            bool success = false;
            while (!success)
            {
                Console.Write(prompt);
                if (!long.TryParse(Console.ReadLine(), out res))
                { 
                    Console.WriteLine("Invalid, enter a whole number.");
                    continue;
                }
                if (res < min || res > max)
                {
                    Console.WriteLine("Error, input must be within range " + min + "-" + max + ". Try again.");
                }
                else
                    success = true;
            }
                return res;
        }
    }
}
