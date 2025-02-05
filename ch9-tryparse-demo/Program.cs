using System.ComponentModel.Design;

namespace ch9_tryparse_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ch 7 exceptions and data validation");

            int nbr1 = 0;
            while (true)
            {
                Console.Write("Enter an integer ");
                if (!Int32.TryParse(Console.ReadLine(), out nbr1))
                {
                    Console.WriteLine("Error enter whole number.");
                }
                else
                {
                    break;
                }
                Console.WriteLine("You entered: " + nbr1);

                Console.WriteLine("bye");
            }
        }
    }
}
