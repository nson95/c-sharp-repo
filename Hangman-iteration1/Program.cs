using System.Runtime.CompilerServices;
using Library4Nick;
namespace Hangman_iteration1
{
    internal class Program
    {
        static string[] images = new string[7];
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Watch this guy die\n");
            MyConsole.PrintLine("-----\r\n|   |\r\n|   O\r\n|  /|\\\r\n|  / \\\r\n|\r\n-------");
            PopulateImages();
            for (int i = 0; i < images.Length; i++)
            {
                MyConsole.PrintLine(images[i]);
                MyConsole.PrintLine("=======");
            }
            
            MyConsole.PrintLine("");

            MyConsole.PrintLine("\nBye");
        }
        static void PopulateImages()
        {
            images[0] = """
                        -----
                        |   |
                        |   0
                        |  /|\
                        |  / \
                        |
                        -------
                        """;
            images[1] = """
                        -----
                        |   |
                        |   0
                        |  /|\
                        |  / 
                        |
                        -------
                        """;
            images[2] = """
                        -----
                        |   |
                        |   0
                        |  /|\
                        |  
                        |
                        -------
                        """;
            images[3] = """
                        -----
                        |   |
                        |   0
                        |  /
                        |  
                        |
                        -------
                        """;
            images[4] = """
            -----
            |   |
            |   0
            |  /
            |  
            |
            -------
            """;
            images[5] = """
            -----
            |   |
            |   0
            |  
            |  
            |
            -------
            """;
            images[6] = """
            -----
            |   |
            |   
            |  
            |  
            |
            -------
            """;

        }
        private static string GetHangmanImage(int incorrectGuesses)
        {
            return images[incorrectGuesses];

        }
    }
}
