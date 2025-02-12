using Library4Nick;
namespace ch7_proj3_guessinggame_withclasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Guess the Number Game");
            MyConsole.PrintLine("++++++++++++++++++++++++++++++++++++\n");
            string choice = "y";
            while (choice == "y")
            {
                Game game = new Game();
                game.PlayGame();
                choice = MyConsole.GetString2("Try again? (y/n): ", "y", "n");
            }
            MyConsole.Print("Bye!");
        }
    }
}
