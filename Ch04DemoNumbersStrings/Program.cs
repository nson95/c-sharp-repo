using System.Net;
using System.Runtime.CompilerServices;

namespace Ch04DemoNumbersStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Numbers and Strings Demo!");
            int dayOfWeek = 5;
            decimal price = 11.99m;
            char letter = 'A';
            int quantity = 6;
            // arithmatic operators

            decimal lineItemTotal = price * quantity;
            int count = 0;
            Console.WriteLine("count = " +count);
            count = count + 1;
            Console.WriteLine("count = " + count);
            count++;
                Console.WriteLine("count = " + count);
            int a = 9;
            int b = 2;
            int quotient = 9 / 2;
            int remainder = 9 % 2;
            Console.WriteLine("quotient =" + quotient);
            Console.WriteLine("remainder =" + remainder);

            double result = a / b;
            Console.WriteLine("Result = " + result);
            double c = 9.0;
            double d = 18;
            result = c / d;
            Console.WriteLine("Result = " + result);

            int counter = 10;
            // increment by 1
            counter = count + 1;
            counter = +1;
            counter++;

            //add 5 to counter 
            counter = counter + 5;
            counter += 5;

            // subtract 
            counter -= 2;
                int e = 5;
            double f = e;


            double g = 6.7;
            int i = (int)g;
            Console.WriteLine("i= " + i);


            Console.WriteLine("counter =" + counter);


            // Math class

            double interestRate = 0.0383902;
            interestRate = Math.Round(interestRate, 4);
            Console.WriteLine("interest rate =" + interestRate);

            // random example lmao so random xd
            Random r = new Random();
            int r1 = r.Next();
            Console.WriteLine("number is " +r1);
            int rollOfTheDice = r.Next(1, 7);
            Console.WriteLine("dice show " + rollOfTheDice);

            // Strings
            string myName = "Nick";
            string firstName = "Joe";
            string lastName = "Burrow";
            string fullName = firstName + " " + lastName;

            // escape sequences - tab, newLine, backslash

            string sentence = "abc\tdef\nghi"; // \t for tab, \n for new line
            Console.WriteLine(sentence);
            string reposFolder = "c:\\repos";
            Console.WriteLine(reposFolder);


            string rawMessage = """
                hello there
                how are you?

                I'm fine, how you doin baby girl?

                Oh nvm, it is time to go.

                Goodbye.

                """;

            Console.WriteLine(rawMessage);


            // get input from console
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Oh, nice to meet you " + name);
            Console.WriteLine("Enter a whole ass number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Oh you would say some stupid number like " + n1 + " wouldn't you.");
            Console.WriteLine("Enter another number smarty pants: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("I bet your dumb ass didn't even know those numbers together equal "+(n1+n2));



            // basic while loop
            // execute the 2 numbers and sum until user is done
            // define choice variable
            string choice = "y";
            while (choice == "y")
            {
                Console.WriteLine("Enter a whole ass number: ");
                int n3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Oh you would say some stupid number like " + n3 + " wouldn't you.");
                Console.WriteLine("Enter another number smarty pants: ");
                Console.WriteLine("Enter another number smarty pants: ");
                int n4 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("I bet your dumb ass didn't even know those numbers together equal " + (n3 + n4));
                Console.WriteLine("Continue? Y/N");
                choice = Console.ReadLine();
            }


            // if statement
            // discount percent if amount > 1000 discamt = .1
            // else if amount > 800 discamt = .08
            // else if amount > 500 discamt = .05
            //otherwise discamt = 0.0

            double amount = 900;
            double discPct = 0.0;
                if (amount >= 1000){
                    discPct = .1;
                }
                else if (amount >= 800)
                {
                    discPct = .08;
                }
                else if (amount >= 500)
                {
                    discPct = .05;
                }
                else
                {
                    discPct = 0.0;
                }










            Console.WriteLine("Bye");
        }
    }
}
