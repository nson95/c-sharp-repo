using System.Diagnostics;
using System.Security.Cryptography;
using Library4Nick;

namespace ch11_proj1_animalcounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            string choice = "y";
            while (choice == "y")
            {
                string animalType = MyConsole.GetString2("What would you like to count today? Sheep or Alligators (s/a): ", "s", "a");
                if (animalType == "a")
                {
                    int numAms = MyConsole.PromptInt("How many? ");
                    Alligator alligator = new Alligator(numAms);
                    MyConsole.PrintLine("Counting alligators...\n");
                    for (int i = 0; i < numAms; i++)
                    {
                        alligator.Count++;
                        MyConsole.PrintLine(alligator.getCountString());
                    }

                }
                else
                {
                    int numShp = MyConsole.PromptInt("How many? ");
                    string name = MyConsole.GetString("What is the sheep's name?");
                    Sheep sheep = new Sheep(numShp, name);
                    MyConsole.PrintLine("Counting sheep...\n");
                    for (int i = 0; i < numShp; i++)
                    {
                        sheep.Count++;
                        MyConsole.PrintLine(sheep.getCountString());
                    }
                }
                MyConsole.PrintLine("\n");
                choice = MyConsole.GetString2("Continue? (y/n)", "y", "n");
            }
            MyConsole.PrintLine("Bye");
        }
    }
}
