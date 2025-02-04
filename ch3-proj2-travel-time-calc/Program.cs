namespace ch3_proj2_travel_time_calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Travel Time Calculator");

            string choice = "y";
            while (choice == "y")
            {   
                int hours = 0;
                int minutes = 0;    
                Console.Write("Enter miles: \t");
                double miles = Double.Parse(Console.ReadLine());
                Console.Write("Enter miles per hour: \t");
                double speed = Double.Parse(Console.ReadLine());
                double totalTime = miles / speed;
                hours = (int)totalTime;
                double remainder = totalTime - hours;
                minutes = (int)remainder * 60;
                Console.WriteLine("Hours: " +hours);
                Console.WriteLine("Minutes: " +minutes);
                Console.Write("Continue? y/n");
                choice = Console.ReadLine().ToLower();
            }
            Console.WriteLine("goodbye");
        }
    }
}
