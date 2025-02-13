using System.Xml.Serialization;
using ch10_proj2_personmanager.Model;
using Library4Nick;

namespace ch10_proj2_personmanager.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Person Manager!\n");
            string choice = "y";
            while (choice == "y")
            {
                string personType = MyConsole.GetString2("Create customer or employee? (c/e): ", "c", "e");
                string firstName = MyConsole.GetString("First Name: ");
                string lastName = MyConsole.GetString("Last Name: ");
                Person p;
                if (personType == "c" )
                {
                    string custNumber = MyConsole.PromptString("Customer number: ");
                    Customer c = new Customer(firstName, lastName, custNumber);
                    p = c;
                }
                else
                {
                    string ssn = MyConsole.PromptString("Social Sec Number: ");
                    Employee e = new Employee(firstName, lastName, ssn);
                    p = e;
                }
                MyConsole.PrintLine(p.ToString());
                MyConsole.PrintLine("You entered a new: " +p.GetType().Name);
                choice = MyConsole.GetString2("Continue? (y/n): ", "y", "n");

            }

            MyConsole.Print("Bye!");
        }
    }
}
