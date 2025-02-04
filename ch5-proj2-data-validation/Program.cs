namespace ch5_proj2_data_validation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print("Welcome to the Area and Perimeter Calculator");
            Print("");
            Print("Enter length: ");
        }

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
        static double GetDouble(string prompt)
        {   

            Print(prompt);
            return double.Parse(GetString(prompt));
            
        }
    }
}
