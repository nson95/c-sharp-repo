using Library4Nick;
namespace bmdb_1
{
    internal class Program : IO
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Bootcamp Movie Data Base!\n");
            string choice = "y";
            while (choice == "y")
            {
                List<Movie> movies = new List<Movie>();
                List<Actor> actors = new List<Actor>();
                Movie m = new Movie();
                Actor a = new Actor();
                string obj = MyConsole.GetString2("Enter an actor or a movie: (m/a)", "m", "a");
                if (obj == "m")
                {
                    m.Title = MyConsole.PromptString("Enter the movie's title: ");
                    m.Rating = MyConsole.GetString2("Enter the age rating (R, PG-13, PG, G): ", "R", "PG-13", "PG", "G");
                    m.ReleaseYear = MyConsole.GetInt("Enter release year: ", 1880, 2026);
                    m.Director = MyConsole.PromptString("Enter director: ");
                    movies.Add(m);
                    IO.SaveMovies(movies);
                    obj = MyConsole.GetString2("Enter an actor or a movie: (m/n)", "m", "n");

                }
                else
                {

                    a.FirstName = MyConsole.PromptString("Enter actor's first name: ");
                    a.LastName = MyConsole.PromptString("Enter actor's last name: ");
                    a.Gender = MyConsole.PromptString("Enter the actor's gender: ");
                    a.BirthDay = MyConsole.GetInt("Will get a bett method: enter 1-10: ", 1, 10);
                    actors.Add(a);
                    IO.SaveActors(actors);
                    obj = MyConsole.GetString2("Enter an actor or a movie: (m/n)", "m", "n");
                }

                choice = MyConsole.GetString2("Continue? (y/n)", "y", "n");
            }

            MyConsole.PrintLine("Goodbye!");
        }
        
    }
}
