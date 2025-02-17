using Library4Nick;
namespace bmdb_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Bootcamp Movie Data Base!\n");
            string choice = "y";
            while (choice == "y")
            {
                Movie m = new Movie();
                Actor a = new Actor();
                string obj = MyConsole.GetString("Enter an actor or a movie: (m/n)");
                if (obj == "m")
                {
                    m.Title = MyConsole.PromptString("Enter the movie's title: ");
                }
                else
                {

                }

                choice = MyConsole.GetString2("Continue? (y/n)", "y", "n");
            }

            MyConsole.PrintLine("Goodbye!");
        }
    }
}
