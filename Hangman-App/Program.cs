using Library4Nick;
using static System.Net.Mime.MediaTypeNames;
namespace Hangman_App
{
    internal class Program
    {
        static string[] images = new string[7];
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to Hangman");
            MyConsole.PrintLine("A man's life is in your hands");
            PopulateImages();
            string choice = "y";
            while (choice == "y")
            {
                string word = WordDictionary.GetRandomWord();
                string hiddenWord = WordDictionary.GetHiddenWord(word);
                MyConsole.PrintLine(word + "\n" + hiddenWord);


                choice = MyConsole.GetString2("Continue? (y/n)", "y", "n");
            }

            

            MyConsole.PrintLine("Buh bye");
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
