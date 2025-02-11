
using Library4Nick;

namespace PigDiceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to The Pig Dice App");
            string choice = "y";

            while (choice == "y")
            {

                choice = MyConsole.GetString2("Continue? (y/n): ", "y", "n");
            }
        }
    }
}
