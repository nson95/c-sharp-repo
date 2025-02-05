namespace ch4_1_tableofpowers_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nbr = 0;
            string choice = "y";
            Console.Write("Welcome to the Squares and Cubes table\n");
            while (choice == "y")
            {
                Console.Write("\nEnter an integer: ");
                try
                {
                    nbr = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Print("Error, entry must be a valid integer.");
                    continue;
                }
                Print("Number" + "\t\t" + "Squared" + "\t\t" + "Cubed");
                Print("======" + "\t\t" + "=======" + "\t\t" + "=====");
                for (int i = 1; i <= nbr; i++)
                {
                    int squared = GetSquared(i);
                    int cubed = GetCubed(i);
                    Print(i +"\t\t"+squared +"\t\t" +cubed);
                }
                Console.Write("Continue? y/n ");
                choice = Console.ReadLine();

            }
            Print("Goodbye");

        }
        static void Print(string msg)
        {
            Console.WriteLine(msg);
        }
        static int GetSquared(int i)
        {
            return i * i;
        }
        static int GetCubed(int i) {
            return i * i * i;
        }
    }
}
