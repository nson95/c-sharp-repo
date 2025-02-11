
namespace ch7proj1_contactslist
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
            Print(prompt);
            return Console.ReadLine();
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
                else PrintLine("Error - invalid year.");
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
                    Print("Error, entry must be either: " + str1 + ", or " + str2 + ". Try again"    );
                }
            }

            return retStr;
        }
    }
    
}

    

