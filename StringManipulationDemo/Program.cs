using Library4Nick;
namespace StringManipulationDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // p 285
            Console.WriteLine("Demo for string manip");
            string word = "superstitious";
            string hiddenWord = "";
            bool winner = false;
            while (!winner)
            {
                foreach (char c in word)
                {
                    hiddenWord += "_";
                }
                foreach (char c in hiddenWord)
                {
                    MyConsole.Print(c + " ");
                }
                hiddenWord = hiddenWord.Trim();
                DisplayHiddenMessge(hiddenWord);
                string letter = MyConsole.PromptString("Guess a letter: ");
                //foreach (char c in word )
                //{
                //    if (letter.Equals(c.ToString()))
                //    {

                //    }
                //}
                char[] word2 = word.ToCharArray();
                char[] hiddenWord2 = hiddenWord.ToCharArray();
                for (int i = 0; i < word.Length; i++)
                {
                    char c = word[i];
                    if (letter.Equals(c.ToString()))
                    {
                        hiddenWord2[i] = c;
                    }
                    else
                    {

                    }

                }
                hiddenWord = new string(hiddenWord2);
                if (hiddenWord.IndexOf("_")==-1)
                {
                    winner = true;
                }
                DisplayHiddenMessge(hiddenWord);
            }

            MyConsole.PrintLine("bye bye bitch");
        }
        public static void DisplayHiddenMessge(string hiddenWord)
        {
            foreach (char c in hiddenWord)
            {
                MyConsole.Print(c + " ");
            }
            MyConsole.PrintLine("");
          
        }
}
}
