using System.Xml;
using Library4Nick;

namespace Ch11_Proj2_AccountBalanceCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Account Application\n");
            MyConsole.PrintLine("Starting balances: ");
            CheckingAccount ca = new CheckingAccount(1.00m);
            ca.Balance = 1000.0m;
            SavingsAccount sa = new SavingsAccount(.01m);
            sa.Balance = 1000.0m;
            DisplayBalances(ca, sa);
            MyConsole.PrintLine("\nEnter transactions for the Month:\n");
            //list starting balances
            string choice = "y";
            while (choice == "y")
            {
                Account a;
                string action = MyConsole.GetString2("Withdraw or deposit? ", "w", "d");
                string account = MyConsole.GetString2("checking or saving? ", "c", "s");
                decimal amount = MyConsole.PromptDecimal("Amount? ");
                if (account == "c")
                {
                    a = ca;
                }
                else 
                    a = sa;
                if (action == "w")
                {
                    a.Withdraw(amount);
                }

                else
                {
                    a.Deposit(amount);
                }

                sa.ApplyInterestPayment();
                ca.SubtractFeeFromBalance();
                MyConsole.PrintLine("\nMonthly Payments and Fees:");
                MyConsole.PrintLine("Checking fee:" +ca.MonthlyFee.ToString("c"));
                MyConsole.PrintLine("Savings Interest Pymt:" + sa.MonthylInterestPayment.ToString("c"));

                MyConsole.PrintLine($"\nDisplay Balnces: \n");
                DisplayBalances(ca, sa);
                // enter transactions/change totals
                choice = MyConsole.GetString2("Continue? (y/n): ", "y", "n");
            }
            static void DisplayBalances(CheckingAccount ca, SavingsAccount sa)
            {
                MyConsole.PrintLine($"Checking: {ca.Balance.ToString("c")}");
                MyConsole.PrintLine($"Savings: {sa.Balance.ToString("c")}");
            }
        }
    }
}
