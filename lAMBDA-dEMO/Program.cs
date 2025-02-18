using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Library4Nick;
namespace lAMBDA_dEMO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Lambda Demo");
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> numSquared = new List<int>();
            int numSq = 0;
            foreach (int number in numbers)
            {
                numSquared.Add(Square(number));
            }
            DisplayListAsString(numSquared, "Look at these numbers, they're all squared!");

            //                                            pass all items through this method then return the results as a list
            List<int> newDemoSquaredList = numbers.Select(Square).ToList();
            DisplayListAsString(numSquared, "Squared list created using a method as a parameter.");

            List<int> squared3 = numbers.Select(num => num*num).ToList();
            DisplayListAsString(squared3, "Squared list created using a lamda expression.");





            //list of all numbers even divisible by 3 with a for loop
            List<int> div3 = new List<int>();
            foreach (int number in numbers)
            {
                if (number % 3 == 0)
                {
                    div3.Add(number);
                    MyConsole.PrintLine($"{number} is divisible by 3");
                }
                else continue;
            }
            foreach (int number in numbers)
            {
                if (IsDivisibleByThree(number))
                {
                    div3.Add(number);
                }
                DisplayListAsString(div3, "DiveThree List 1:");
                List<int> div32 = numbers.FindAll(IsDivisibleByThree).ToList();
                DisplayListAsString(div32, "DivThree list 2:");
                //                               (return all items x => as they would be transformed by)
                //                                   could think of like a where clause
                List<int> div42 = numbers.FindAll(x => x % 3 ==0).ToList();
                DisplayListAsString(div32, "DivThree list 2:");

            }

            //list of all numbers even divisible by 3 using a function





        }
        private static bool IsDivisibleByThree(int nbr)
        {
            return nbr % 3 == 0;
        }
        private static int Square(int nbr)
        {
            return nbr * nbr;
        }
        private static void DisplayListAsString(List<int> numbers, string header)
        {
            string result = "========================================\n";
            result += header + "\n";
            result += "========================================\n";
            foreach (var value in numbers)
            {
                result += value.ToString() + " ";
            }
            result += "\n";
            MyConsole.PrintLine(result);
        }
    }
}
