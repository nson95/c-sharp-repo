using System.ComponentModel.Design;

namespace ch12_classes_demo
{
    internal class Program
    {
        static List<Movie> Movies = new List<Movie>();
        static void Main(string[] args)
        {
            Movie newMovie = new Movie();
            Console.WriteLine("Welcome to the Classes demo!");
            int id = MyConsole.PromptInt("Movie ID: ");
            string title = PromptString("Movie title: ");
            int year = PromptInt("Year: ");
            string ageRating = PromptString("Age rating: ");
            string director = PromptString("Director: ");
            newMovie = new Movie(id, title, year, ageRating, director);
            Movies.Add(newMovie);
            newMovie.Id = 1;
            newMovie.Title = "Elf";
            newMovie.Year = 2004;
            newMovie.ageRating = "PG";
            newMovie.Director = "Jon Favreau";
            // need to store movie, capture movies and display all movies when done
            // use instructions on p 380 in book
            // important terms for interviews on oop on p 376/377
            PrintLine(newMovie.ToString());

            Console.WriteLine("Bye!");

        }
        static void Print(string msg)
        {
            Console.Write(msg);
        }
        static void PrintLine(string msg)
        {
            Console.WriteLine(msg);
        }
        static string PromptString(string prompt)
        {
            Print(prompt);
            return Console.ReadLine();
        }
        static int PromptInt(string prompt)
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

    }
}
