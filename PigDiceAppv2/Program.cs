using System.Diagnostics.Metrics;
using System.Runtime;
using System.Runtime.CompilerServices;
using Library4Nick;

namespace PigDiceAppv2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the pig dice app\n");
            Random randy = new Random();   
            string choice = "y";
            while (choice == "y")
            {
                int highscore = 0;
                int numGames = MyConsole.PromptInt("How many times would you like to play? ");
                for (int i = 0; i < numGames; i++)
                {
                    int roll = 0;
                    int score = 0;
                    while (roll!=1)
                    {
                    roll = randy.Next(1,7);
                        if (roll != 1)
                        {
                            score += roll;
                        }
                    }
                    highscore = (score >= highscore) ? score : highscore;
                    // turnary operator p 150 in csharp book
                    MyConsole.Print($"Highscore: {highscore}");
                    choice = MyConsole.GetString2("Continue? (y/n): ", "y", "n");
                }
            }
        }
    }
}
