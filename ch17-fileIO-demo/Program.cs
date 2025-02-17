using Library4Nick;

namespace ch17_fileIO_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi welcome to my MF File IO Demo\n");
            string dir = @"C:\C#\Files\";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
                MyConsole.PrintLine($"{dir} created");
            }
            else
            {
                MyConsole.Print("directory already exists");
            }
            string path = dir + "names.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
                MyConsole.PrintLine($"{path} created");
            }
            else
            {
                MyConsole.PrintLine("path/file already exists");
            }

            // write names to file :))))))))))))))))))))
            //StreamWriter writer = new StreamWriter(new FileStream(path, FileMode.Create, FileAccess.Write));
            //writer.WriteLine("Poop");
            //writer.WriteLine("Pee");
            //writer.WriteLine("Butts");
            //writer.WriteLine("Koolaid");
            //writer.WriteLine("Hugh Mongous");
            //writer.Close();
            ////MyConsole.PrintLine("I added stuff to the text file homie");
            //MyConsole.PrintLine("== reading my text file names.text");
            StreamReader reader = new StreamReader(path);
            //             
            List<string> lines = new List<string>();
            while (reader.Peek() != -1)
            {
                string row  = reader.ReadLine() ?? "";
                lines.Add(row);
            }
            reader.Close();

            foreach (string line in lines)
            {
                MyConsole.PrintLine($"line: {line}");
            }
            new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
            Console.WriteLine("Goodbye MF");


        }
    }
}
