using System.ComponentModel.Design;

namespace ch6_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ch 6 demos");


            // get title, year, rating and director for movie
            string choice = "y";
            while (choice == "y")
            {
                string title = GetString("Enter a Movie Title: ");
                int year = GetInt("Enter release year: ", 1900, 2000);
                string rating = GetString("Enter age rating: ");
                string director = GetString("Enter the Director: ");
                choice = GetString2("Continue? y/n: ", "y", "n");
            }
            Print("Goodbye");


            

            
            //static - doesnt need instance of class, void - returns nothing 
            static void Print(string msg, string endLine = "\n")
            {
                Console.Write(msg + endLine);
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


            static int getInt(string prompt)
            {
                Print(prompt, "");
                return Int32.Parse(Console.ReadLine());
            }


            static int GetInt(string prompt, int min, int max)
            {
                bool success = false;
                int nbr = 0;
                while (!success)
                {
                    Print(prompt, "");
                    nbr = Int32.Parse(Console.ReadLine());
                    if (nbr < min || nbr > max)
                    {
                        Print("Error, number out of range. Try again.");
                    }
                    else
                        success = true;
                }
                return nbr;
            }
            Print("hey baby how you doin");
            Console.WriteLine("Goodbye");
        }
    }
}
