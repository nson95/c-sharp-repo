using System.Globalization;

namespace csharp_2_2_LetterGradeConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Letter Grade Converter");
            string choice = "y";
            while (choice == "y" || choice == "Y")
            {
                Console.Write("Enter Numeric Grade: ");
                int numberGrade = Int32.Parse(Console.ReadLine());
                Console.Write("Continue? y/n");
            }
            Console.WriteLine("Goodbye.");
        }
    }
}
