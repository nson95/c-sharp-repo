namespace ch5_proj3_guessing_game
{
    internal class Program
    {
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
                int userChoice = getInt("Enter number: ");
                compareNumber(secretNbr, userChoice);

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
        static int getInt(string prompt)
        {
            Print(prompt, "");
            return Int32.Parse(Console.ReadLine());
        }
        static string compareNumber(int i, int j)
        {
            bool success = false;


        }
    }
}
