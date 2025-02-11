namespace ch7_proj4_dicerollerapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Dice Roller App\n");
            string choice = MyConsole.GetString2("Would you like to roll the dice? ", "y", "n");
            while (choice == "y")
            {
                
                Die die = new Die(MyConsole.RollOfDice(), MyConsole.RollOfDice());
                Console.WriteLine("first roll " +die.DieRoll);
                choice = MyConsole.GetString2("Roll again? ", "y", "n");
            }
        }
    }
}
