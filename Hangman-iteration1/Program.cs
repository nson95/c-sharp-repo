using Library4Nick;
namespace Hangman_iteration1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Watch this guy die\n");
            MyConsole.PrintLine("-----\r\n|   |\r\n|   O\r\n|  /|\\\r\n|  / \\\r\n|\r\n-------");
            string hangman = @"""
            -----
            |   |
            |   O
            |  /|\
            |  / \
            |
            -------
            """;
            MyConsole.PrintLine(hangman);

            MyConsole.PrintLine("\nBye");
        }
    }
}
