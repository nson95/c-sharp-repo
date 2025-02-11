
namespace ch7proj1_contactslist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Contacts List App");
            string choice = "y";
            while (choice == "y")
            {
                Contact contact = new Contact();
                contact.FirstName = MyConsole.GetString("Enter first name: ");
                contact.LastName = MyConsole.GetString("Enter last name: ");
                contact.Email = MyConsole.GetString("Enter email: ");
                contact.Phone = MyConsole.GetString("Enter phone number: ");
                MyConsole.Print(contact.PrintMessage());

                choice = MyConsole.GetString2("Continue? y/n", "y", "n");
            }
            MyConsole.Print("Bye!");
        }
    }
}
