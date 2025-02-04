using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualBasic;

namespace notes_day2_sql
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to a stoplight");
            string choice = "y";
            while (choice == "y")
            {
                Console.WriteLine("Welcome to a stoplight");
                Console.WriteLine("light color? (r,y,g): ");
                string lightColor = Console.ReadLine();
                if (lightColor == "r")
                {
                    Console.WriteLine("Stop");
                }

                else if (lightColor == "y")
                {
                    Console.Write("Distance to light in yards?");
                    int yardsAway = Convert.ToInt32(Console.ReadLine());
                    string msg = "";
                    if (yardsAway < 20)
                    {
                        msg = "Go!";
                    }
                    if (yardsAway < 30)
                    {
                        msg = "Spped up and go";
                    }
                    else
                    {
                        msg = "Slow Down";
                    }
                    Console.WriteLine(msg);
                }
                else if (lightColor == "g")
                {
                    Console.WriteLine("Go");
                }
                else
                {
                    Console.WriteLine(lightColor + " is an invalid light color");
                }




                Console.Write("Continue? y/n ");
                choice = Console.ReadLine();
            }

            bool success = false;
            int month = 0;
            while (!success)
            {
                Console.WriteLine("Enter month number: ");
                //assume they enter whole number
                month = Convert.ToInt32(Console.ReadLine());
                if (month < 1 || month > 12)
                {
                    Console.WriteLine("invalid month number, try again");
                }
                else
                    success = true;
            }
            Console.WriteLine("Month entered: " + month);

            // loop until user enters even number 
            while (true)
            {
                Console.WriteLine("In a while true loop");
                Console.Write("Enter an even number: ");
                int nbr = Convert.ToInt32(Console.ReadLine());
                if (nbr%2==0)
                {
                    break; // break can be used to exit any loop.
                }
            }


            // do not use do while loops, unless you need the values all tested at least once

            // for loops
            // summing 0-10 with for loop
            int sum = 0;
            string numberStr = "";
            // (starting value; boolean to run until true; how much to increment by)
            for (int i = 0; i <= 10; i++)
            {
                sum += i;
                numberStr += i + " ";

            }
            Console.WriteLine(numberStr);


            Console.WriteLine("Goodbye");
        }
    }
}
