
namespace Library4Nick
{
    public class MyConsole
    {

        public static void Print(string msg)
        {
            Console.Write(msg);
        }
        public static void PrintLine(string msg)
        {
            Console.WriteLine(msg);
        }
        public static string PromptString(string prompt)
        {
            string retStr = null;
            bool success = false;
            while (!success) {
                Print(prompt);
                retStr = Console.ReadLine();
                if (retStr != null) {
                    success = true;
                }
                else
                {
                    Print("Error, must be an entry");
                }

            }
            return retStr;      
        }
        public static void PrintList<T>(List<T> list)
        {
            foreach (T item in list)
            {
                PrintLine(item.ToString());
            }
        }
        public static char GetChar(string prompt)
        {
            char retChr = '0';
            Print(prompt);
            bool isValid = false;
            while (!isValid)
            {
                if (char.TryParse(Console.ReadLine(), out retChr))
                    isValid = true;
                else PrintLine("Error - invalid letter.");
            }



            return retChr;
        }
        public static int PromptInt(string prompt)
        {
            Print(prompt);
            int result = 0;
            bool isValid = false;
            while (!isValid)
            {
                if (Int32.TryParse(Console.ReadLine(), out result))
                    isValid = true;
                else PrintLine("Error - invalid integer.");
            }



            return result;
        }
        public static string GetString(string prompt)
        {
            Print(prompt);
            return Console.ReadLine();
        }
        public static string GetString2(string prompt, string str1, string str2)
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
                    Print("Error, entry must be either: " + str1 + ", or " + str2 + ". Try again");
                }
            }

            return retStr;
        }
        public static string GetString2(string prompt, string str1, string str2, string str3, string str4)
        {
            string retStr = "";
            bool success = false;
            while (!success)
            {
                retStr = GetString(prompt);
                if (retStr.ToUpper() == str1 || retStr.ToUpper() == str2 || retStr.ToUpper() == str3 || retStr.ToUpper() == str4)
                {
                    success = true;
                }
                else
                {
                    Print("Error, entry must be either: " + str1 + ", or " + str2+ ", or " + str3 + ", or " + str4 +". Try again");
                }
            }

            return retStr;
        }
        public static int GetInt(string prompt, int min, int max)
        {
            int results = 0;
            bool success = false;
            while (!success)
            {
                Console.Write(prompt);
                if (!int.TryParse(Console.ReadLine(), out results))
                {
                    Console.WriteLine("Error, result of at bat must be a valid number.");
                    continue;
                }
                if (results > max || results < min)
                {
                    Console.WriteLine($"Error, results must be between {min} and {max}");
                }
                else
                {
                    success = true;
                }
            }
            return results;
        }
        public static decimal PromptDecimal(string prompt)
        {
            decimal result = 0m;
            bool isValid = false;
            while (!isValid)
            {
                Print(prompt);
                if (Decimal.TryParse(Console.ReadLine(), out result))
                {
                    isValid = true;
                }
                else
                {
                    PrintLine("Error - invalid decimal.");
                }
            }

            return result;
        }
    }
    
}

    

