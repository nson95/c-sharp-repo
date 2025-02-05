using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

namespace ch4_proj3_tip_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tip Calculator\n");
            string choice = "y";
            double cost = 0;
            while (choice == "y")
            {
                Console.WriteLine("Cost of meal: ");
                try
                {
                    cost = double.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Error, entry must be a valid cost.");
                }
                PrintTips(cost);
                choice = GetString("Continue? y/n ", "y", "n");
            }
        }
        static string GetString(string prompt)
        {
            Console.WriteLine(prompt, "");
            return Console.ReadLine();
        }
        static string GetString(string prompt, string str1, string str2)
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
                    Console.WriteLine("Error, entry must be either: " + str1 + ", or " + str2 + ". Try again", "");
                }
            }

            return retStr;
        }
            static void PrintTips(double mealCost)
        {
            Console.WriteLine("\n15%\nTip amount:\t" + "$" + Math.Round((mealCost * .15), 2) +"\nTotal amount:\t" + "$" + Math.Round((mealCost * .15)+(mealCost), 2));
            Console.WriteLine("\n20%\nTip amount:\t" + "$" + Math.Round((mealCost * .2), 2) + "\nTotal amount:\t" + "$" + Math.Round((mealCost * .2) + (mealCost), 2));
            Console.WriteLine("\n25%\nTip amount:\t" + "$" + Math.Round((mealCost * .25), 2) + "\nTotal amount:\t" + "$" + Math.Round((mealCost * .25) + (mealCost), 2)+"\n");
        }
    }
}
