using System.Xml.Serialization;

namespace ch4_proj2_factorial_calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Factorial Calculator");

                int nbr = 0;
                int res = 1;
                bool success = false;
            string choice = "y";
            while (choice == "y")
            {
                success = false;
                res = 1;
                while (!success)
                {
                    try
                    {
                Print("Enter an integer that is greater than 0 and less than 10: ");
                        nbr = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Print("Error, input must be a valid integer: ");
                        continue;
                    }
                    if (nbr > 10 || nbr < 0)
                    {
                        Print("Error, must be between 1 and 10");
                    }
                    else
                    {
                        for (int i = 1; i <= nbr; i++)
                        {
                            res *= i;
                        }
                        success = true;
                    }

                }
                Print("The factorial of " + nbr + " is " + res);
                Print("Continue? y/n ");
                choice = Console.ReadLine();
            }
            Print("Goodbye");
        }

        static void Print(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
