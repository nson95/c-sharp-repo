using Library4Nick;
using static System.Net.Mime.MediaTypeNames;
namespace Hangman_App
{
    internal class Program
    {
        static string[] images = new string[7];
        static void Main(string[] args)
        {
            PopulateImages();
            PlayGame();
            MyConsole.PrintLine("Buh bye");
        }
        public static string GetReplacementString(string input, int index, char repChar)
        {
            string retStr = "";
            if (index >= 0 && index < input.Length - 1)
            {
                retStr += input.Substring(0, index) + repChar + input.Substring(index, input.Length - 1);
            }
            else
            {

            }
            return retStr;
        }
        public static string ReplaceChar(string input, int index, char newChar)
        {
            if (index < 0 || index >= input.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            }

            // Convert the string to a character array, modify the character at the specific index, and then join it back into a string
            char[] charArray = input.ToCharArray();
            charArray[index] = newChar;
            return new string(charArray);
        }

        public static void PlayGame()
        {
            {
                string choice = "y";
                while (choice == "y")
                {
                string word = WordDictionary.GetRandomWord();
                string hiddenWord = WordDictionary.GetHiddenWord(word);
                int incorrectGuesses = 0;
                bool wordGuessed = false;
                char guess = '0';
                    List<char> guessedLetters = new List<char>();
                    MyConsole.PrintLine("Welcome to Hangman");
                    MyConsole.PrintLine("A man's life is in your hands");
                    //MyConsole.PrintLine(word + "\n" + hiddenWord);
                    while (incorrectGuesses < 6 && !wordGuessed)
                    {
                        MyConsole.PrintLine($"{images[0]}\n\n{hiddenWord}");
                        MyConsole.PrintLine($"{word}");
                        guess = MyConsole.GetChar("Guess a letter: ");
                        if (!word.Contains(guess))
                        {
                            MyConsole.PrintLine("Nope, no matches!");
                            incorrectGuesses++;
                            guessedLetters.Add(guess);
                            MyConsole.PrintLine(DisplayHangmanImage(incorrectGuesses));
                            MyConsole.PrintLine(PrintList(guessedLetters));
                            MyConsole.PrintLine(hiddenWord);


                        }
                        else
                        {

                            char[] wordForProcessing = word.ToCharArray();
                            char[] hiddenForProcessing = hiddenWord.ToCharArray();
                            for (int i = 0; i < wordForProcessing.Length; i++)
                            {
                                char c = wordForProcessing[i];
                                if (c.Equals(guess))
                                {
                                    hiddenForProcessing[i] = c;
                                }
                                else
                                {
                                }
                            }
                            hiddenWord = new string(hiddenForProcessing);
                            guessedLetters.Add(guess);
                            if (hiddenWord == word)
                            {
                                DisplayHangmanImage(incorrectGuesses);
                                MyConsole.PrintLine($"Congrats! You got it!\n\n{word} was the word!");
                                wordGuessed = true;
                            }
                            continue;

                        }
                    }
                    choice = MyConsole.GetString2("Continue? (y/n)", "y", "n");

                }
            }





        }
        public static string PrintList<T>(List<T> listy)
        {
            string retStr = "";
            foreach (T item in listy)
            {
                retStr += ($"{item}  ");
            }
            return ("You have guessed: " + retStr.Trim());
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
        private static string DisplayHangmanImage(int incorrectGuesses)
        {
            return images[incorrectGuesses];

        }
    }
}
