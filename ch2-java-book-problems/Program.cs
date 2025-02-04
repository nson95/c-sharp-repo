namespace ch2_java_book_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Registration Form\t");
            Console.WriteLine("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter year of birth: ");
            int birthYear = Convert.ToInt32(Console.ReadLine());
            string fullName = firstName + " " + lastName;
            Console.WriteLine("\n\nWelcome " + fullName
                + "\nYour Registration is complete");
            Console.WriteLine("Your temporary password is: "
                + firstName + "*" + birthYear);
        }
    }
}
