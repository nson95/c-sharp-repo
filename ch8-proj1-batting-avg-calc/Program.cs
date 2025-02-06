namespace ch8_proj1_batting_avg_calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Batting Average Calculator");
            string choice = "y";
            while (choice == "y")
            {
                int results = 0;
                int atBats = 0;
                double sum = 0;
                double hits = 0;
                atBats = GetAtBats("Enter number of times at bat: ");
                Console.WriteLine();
                Console.WriteLine("0 = out, 1 = single, 2 = double, 3 = triple, 4 = home run");
                int[] BattingChart = new int[atBats];
                for (int i = 0; i < BattingChart.Length; i++)
                {
                    results = GetResults("Result for at-bat " + (i+1) + ":");
                    BattingChart[i] = results;
                    sum += results;
                }

                foreach (int AtBat in BattingChart)
                {
                    if (AtBat > 0)
                    {
                        hits++;
                    }
                }
                double roundedAvg = Math.Round(hits / (double)BattingChart.Length, 3);
                double roundedSlgPct = Math.Round(sum / (double)BattingChart.Length, 3);
                Console.WriteLine();
                Console.WriteLine("Batting average: " + roundedAvg.ToString("F3"));
                Console.WriteLine("Slugging percentage: " +roundedSlgPct.ToString("F3"));
                Console.WriteLine();


                Console.Write("Another player? y/n ");
                choice = Console.ReadLine().ToLower();
                Console.WriteLine();


            }


            Console.WriteLine("Bye!");
        }
        private static int GetAtBats(string prompt)
        {
            int atBats = 0;
            bool success = false;
            while (!success)
            {
                Console.Write(prompt);
                if (!int.TryParse(Console.ReadLine(), out atBats))
                {
                    Console.WriteLine("Error, at bats entered must be a valid number.");
                    continue;
                }
                if (atBats > 30 || atBats < 1)
                {
                    Console.WriteLine("Error, at bats must be between 1 and 30");
                }
                else
                {
                    success = true;
                }
            }
            return atBats;
        }
        private static int GetResults(string prompt)
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
                if (results > 4 || results < 0)
                {
                    Console.WriteLine("Error, results must be between 0 and 4");
                }
                else
                {
                    success = true;
                }
            }
            return results;
        }
    }
}
