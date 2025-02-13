using Library4Nick;

namespace Ch11_Proj2_AccountBalanceCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Account Application\n");


            //list starting balances
            string choice = "y";
            while (choice == "y")
            {
                // enter transactions/change totals
                choice = MyConsole.GetString2("Continue? (y/n): ", "y", "n");
            }
        }
    }
}
