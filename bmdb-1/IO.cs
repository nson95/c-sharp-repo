using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bmdb_1
{
    internal interface IO
    {
        private const string Dir = @"C:\C#\Files\";
        private const string Path = Dir + "BMDB.txt";
        private const string Sep = "|";
        public static void SaveMovies(List<Movie> movies)
        {
            using
            StreamWriter streamWriter = new StreamWriter(new FileStream(Path, FileMode.Create, FileAccess.Write));
            foreach (Movie movie in movies)
            {
                streamWriter.Write("Movie:\t");
                streamWriter.Write(movie.Title + Sep);
                streamWriter.Write(movie.Rating + Sep);
                streamWriter.Write(movie.ReleaseYear + Sep);
                streamWriter.Write(movie.Director);
            }
        }
        public static void SaveActors(List<Actor> actors)
        {
            using
            StreamWriter streamWriter = new StreamWriter(new FileStream(Path, FileMode.Create, FileAccess.Write));
            foreach (Actor actor in actors)
            {
                streamWriter.Write("Actor:\t");
                streamWriter.Write(actor.FirstName + " ");
                streamWriter.Write(actor.LastName + Sep);
                streamWriter.Write(actor.Gender + Sep);
                streamWriter.Write(actor.BirthDay);
            }
        }

    }
}
