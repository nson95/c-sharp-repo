namespace ch5_proj1_dice_roller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print("Dice Roller");
            Print("");
            string choice = GetString2("Roll the dice? (y/n)", "y", "n");
            while (choice == "y")
            {
                int die1 = RollDice();
                int die2 = RollDice();
                Print("Die 1: " +die1);
                Print("Die 2: " +die2);
                if (die1 == 1 && die2 == 1) {
                    Print("Total: " + (die1 + die2));
                    Print("Snake eyes!");
                }
                else if (die1 == 6 && die2 == 6)
                {
                    Print("Total: " + (die1 + die2));
                    Print("Box cars!");
                }
                else
                    Print("Total: " + (die1 + die2));

                choice = GetString2("Roll again? (y/n)", "y", "n");
            }

        }

        static void Print(string msg, string endLine = "\n")
        {
            Console.WriteLine(msg +endLine);
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
                    Print("Error, entry must be either: " + str1 + ", or" + str2 + ". Try again");
                }
            }

            return retStr;
        }
        static int RollDice()
        {
            Random random = new Random();  
            int faceUp = (int) (random.NextSingle() * 6) + 1;
            return faceUp;
        }
    }
}
