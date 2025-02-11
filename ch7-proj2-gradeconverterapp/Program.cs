namespace ch7_proj2_gradeconverterapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Letter Grade Converter\n\n");
            string choice = "y";
            while (choice == "y")
            {
                Grade grade = new Grade(MyConsole.GetInt("Enter numerical grade: ", 0, 100));
                MyConsole.PrintLine($"{grade.ToString()}\n\n"); 
                choice = MyConsole.GetString2("Continue? y/n ".ToLower(), "y", "n");
            }
            MyConsole.PrintLine("Bye!");
        }
    }
}
