using Library4Nick;

namespace sorted_list_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Hi this is my sorted list demo");
            // p.262
            SortedList<string, string> usStates = new SortedList<string, string>();
            usStates.Add("OH", "Ohio");
            usStates["IN"] = "Indiana";

            usStates["MI"] = "Michigan";
            foreach (KeyValuePair<string, string> pair in usStates)
            {
                MyConsole.PrintLine($"{pair.Key}: {pair.Value}");
            }
            MyConsole.PrintLine("Buh bye");
            usStates = new SortedList<string, string> {
            { "AL", "Alabama" }, { "AK", "Alaska" }, { "AZ", "Arizona" },
            { "AR", "Arkansas" }, { "CA", "California" }, { "CO", "Colorado" },
            { "CT", "Connecticut" }, { "DE", "Delaware" }, { "FL", "Florida" },
            { "GA", "Georgia" }, { "HI", "Hawaii" }, { "ID", "Idaho" },
            { "IL", "Illinois" }, { "IN", "Indiana" }, { "IA", "Iowa" },
            { "KS", "Kansas" }, { "KY", "Kentucky" }, { "LA", "Louisiana" },
            { "ME", "Maine" }, { "MD", "Maryland" }, { "MA", "Massachusetts" },
            { "MI", "Michigan" }, { "MN", "Minnesota" }, { "MS", "Mississippi" },
            { "MO", "Missouri" }, { "MT", "Montana" }, { "NE", "Nebraska" },
            { "NV", "Nevada" }, { "NH", "New Hampshire" }, { "NJ", "New Jersey" },
            { "NM", "New Mexico" }, { "NY", "New York" }, { "NC", "North Carolina" },
            { "ND", "North Dakota" }, { "OH", "Ohio" }, { "OK", "Oklahoma" },
            { "OR", "Oregon" }, { "PA", "Pennsylvania" }, { "RI", "Rhode Island" },
            { "SC", "South Carolina" }, { "SD", "South Dakota" }, { "TN", "Tennessee" },
            { "TX", "Texas" }, { "UT", "Utah" }, { "VT", "Vermont" },
            { "VA", "Virginia" }, { "WA", "Washington" }, { "WV", "West Virginia" },
            { "WI", "Wisconsin" }, { "WY", "Wyoming" }
        };

            MyConsole.PrintLine("All 50 States");
            string sa = "";
            while (sa != "EX")
            {
                sa = MyConsole.PromptString("State Abbrev: ").ToUpper();
                if (sa == "EX")
                {
                    break;
                }
                string sn = "";
                try
                {
                    sn = usStates[sa];
                }
                catch (Exception ex)
                {
                    MyConsole.PrintLine($"Error - no state for '{sa}'.");
                    continue;
                }
                MyConsole.PrintLine(usStates[sn]);
            }
        }
        // sorted list is more effecient than dictionaries when it comes to memory efficiency
        // dictionaries are faster with insertion and deletion

        // p.263 collection initializer 
    }
}
