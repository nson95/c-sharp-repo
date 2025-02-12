using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Library4Nick;

namespace ch7_proj3_guessinggame_withclasses
{
    public class Game
    {
        public int Number { get; set; }



        public Game()
        {

        }
        public void PlayGame()
        {
            bool success = false;
            int guess = MyConsole.GetInt("I'm thinking of a number between 1 to 100." +
                "\nTry to guess it.\n\n" +
                "Enter number: ", 1, 100);
            int numTries = 0;
            Random randy = new Random();
            int secretNumber = randy.Next(1, 101);
            while (!success)
            {
                if (guess == secretNumber)
                {
                    PrintSummaryMessage(numTries);
                    success = true;
                }

                else if (guess - secretNumber > 10)
                {
                    MyConsole.Print("Way too high! Guess again.\n");
                    guess = MyConsole.GetInt("Enter number: ", 1, 100);
                    numTries++;
                }
                else if (guess - secretNumber < -10)
                {
                    MyConsole.Print("Way too low! Guess again.\n");
                    guess = MyConsole.GetInt("Enter number: ", 1, 100);
                    numTries++;
                }
                else if (guess > secretNumber)
                {
                    MyConsole.Print("Too high! Guess again.\n");
                    guess = MyConsole.GetInt("Enter number: ", 1, 100);
                    numTries++;
                }
                else if (guess < secretNumber)
                {
                    MyConsole.Print("Too low! Guess again.\n");
                    guess = MyConsole.GetInt("Enter number: ", 1, 100);
                    numTries++;
                }
            }



        }

        public void PrintSummaryMessage(int total)
        {
            if (total < 7)
            {
                MyConsole.PrintLine($"You got it in {total + 1} tries." +
                    $"\nNot too bad! You've got some potential.");
            }
            else if (total < 3)
            {
                MyConsole.PrintLine($"You got it in {total + 1} tries." +
                    $"\nGreat work! You are a mathematical wizard.");
            }
            else
            {
                MyConsole.PrintLine($"You got it in {total + 1} tries." +
                    $"\nWere you even trying?");
            }
        }
    }
}
