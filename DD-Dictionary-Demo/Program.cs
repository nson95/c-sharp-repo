using Library4Nick;
namespace DD_Dictionary_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Hello, World!");

            Dictionary<string, string> usStates = new Dictionary<string, string>();
            usStates.Add("OH", "Ohio");
            usStates["Indiana"] = "IN";
            MyConsole.PrintLine("Enter some US States. Enter EX to exit\n\n");
            string stateAbrev = "";
            while (stateAbrev != "EX")
            {
                stateAbrev = MyConsole.PromptString("Enter US State abbreviation: ").ToUpper();
                if (stateAbrev == "EX")
                    break;
                string stateName = MyConsole.PromptString("Enter state name: ");
                usStates.Add(stateName, stateAbrev);
            }

            MyConsole.PrintLine("GetAdd states");
            MyConsole.PrintLine($"Key 'OH' = {usStates["OH"]}");
            MyConsole.PrintLine("Display all keys");
            // List<string> keys = new List<string>(usStates.Keys);
            foreach (string s in usStates.Keys)
            {
                MyConsole.PrintLine(s +", ");
            }
            MyConsole.PrintLine("Display all values");
            // List<string> values = new List<string>(usStates.Values);
            foreach (string s in usStates.Values)
            {
                MyConsole.PrintLine(s + ", ");
            }
            // store in dictionary
            MyConsole.PrintLine("Display all key values");
            foreach (KeyValuePair<string, string> entry in usStates)
            {
                MyConsole.PrintLine($"{entry.Key}--{entry.Value}");
            }

            MyConsole.PrintLine("Remove an entry: ");
            usStates.Remove("OH");
            MyConsole.PrintLine("Buh bye");
        }
    }
}
