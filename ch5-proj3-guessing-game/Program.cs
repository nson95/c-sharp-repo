using System.Security.Cryptography;

namespace ch5_proj3_guessing_game
{
    internal class Program
    {
        // constants
        const int MIN_VAL = 1;
        const int MAX_VAL = 100;
        static void Main(string[] args)
        {
            Print("Welcome to the Guess the Number Game");
            Print("++++++++++++++++++++++++++++++++++++");
            Print("");
            string choice = "y";
            while (choice == "y")
            {
                Print("I'm thinking of a number from 1 to 100.\nTry to guess it.");
                Print("");
                int secretNbr = createNumber();
                int userChoice = GetInt("Enter number: ", 0, 100);
                Guess(secretNbr, userChoice);
                choice = GetString2("Continue? y/n: ", "y", "n");
            }
            Print("Bye! Come back soon.");
        }

        private static void Guess(int secretNbr, int userChoice)
        {
            int incr = 0;
            bool success = false;
            while (!success)
            {
                if (secretNbr == userChoice)
                {
                    incr++;
                    Console.WriteLine("");
                    Print(SumMessage(incr));
                    success = true;
                }
                else if (secretNbr - userChoice > 10)
                {
                    incr++;
                    Console.Write("Way too low! try again.");
                    userChoice = Int32.Parse(Console.ReadLine());
                }
                else if (secretNbr - userChoice < -10)
                {
                    incr++;
                    Console.Write("Way too high! try again.");
                    userChoice = Int32.Parse(Console.ReadLine());
                }
                else if (secretNbr > userChoice)
                {
                    incr++;
                    Console.Write("Too low! try again.");
                    userChoice = Int32.Parse(Console.ReadLine());
                }
                else if (secretNbr < userChoice)
                {
                    incr++;
                    Console.Write("Too high! Try again.");
                    userChoice = Int32.Parse(Console.ReadLine());
                }
            }
        }

        static void Print(string msg, string endLine = "\n")
        {
            Console.WriteLine(msg);
        }
        static int createNumber()
        {
            Random randy = new Random();
            int randomNbr = randy.Next(1, 101);
            return randomNbr;
        }

        static int GetInt(string prompt)
        {
            Print(prompt, "");
            return Int32.Parse(Console.ReadLine());
        }
      
        //throw/catch/handle exceptions
        static int GetInt(string prompt, int min, int max)
        {
            bool success = false;
            int nbr = 0;
            while (!success)
            {
                Print(prompt, "");
                try
                {
                    nbr = Int32.Parse(Console.ReadLine());
                }
              /*  catch
                {
                    Print("Error, input must be a whole number.");
                    continue;
                }
              */  catch (Exception e)
                {
                    Print("Error, input must be a whole number.");
                   // Console.Error.WriteLine("Exception: " +e.Message);
                   // Console.Error.WriteLine("Exception: " + e.StackTrace);
                   // Console.Error.WriteLine("Exception: " + e.ToString);
                    continue;
                }
                if (nbr < min || nbr > max)
                {
                    Print("Error, number out of range. Try again.");
                }
                else
                    success = true;
            }
            return nbr;
        }
        static string SumMessage(int numTries)
        {
            string retMsg = "";
            if (numTries <= 3)
            {
                retMsg = "You got it in " +numTries +" tries."+".\nGreat work! You are a mathematical wizard!";
            }
            else if (numTries > 3 && numTries <= 7 )
            {
                retMsg = "You got it in " + numTries + " tries." + ".\nNot too bad! You've got some potential!";
            }
            else if (numTries > 7)
            {
                retMsg = "You got it in " + numTries + " tries." + ".\nWhat took you so long? Maybe you should take some lessons.";
            }
            return retMsg;
        }
        static string GetString(string prompt)
        {
            Print(prompt, "");
            return Console.ReadLine();
        }
        static string GetString2(string prompt, string str1, string str2)
        {
            string retStr = "";
            bool success = false;
            while (!success)
            {
                retStr = GetString(prompt);
                if (retStr.ToLower() == str1 || retStr.ToLower() == str2)
                {
                    success = true;
                }
                else
                {
                    Print("Error, entry must be either: " + str1 + ", or " + str2 + ". Try again", "");
                }
            }

            return retStr;
        }
        
    }
}
