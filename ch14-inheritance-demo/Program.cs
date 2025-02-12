using ch12_classes_demo;
using Library4Nick;

namespace ch14_inheritance_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my demo abt Inheritance");
            // 'derived/child/sub class' will inherit the properties, methods and other members of a 'base/parent/super class'
            // then the objects that are creaeted from the derived class can use these inherited members. 
            // the derived class can also provide its own members that extend the base class and
            // override and methods



            Movie movie = new Movie(1, "Test", 2008, "M", "Favreau");
            Product p1 = new Product("C#", "Murach's C# Book", 88.99m);
            MyConsole.Print(p1.GetDisplayText("|"));
            MyConsole.Print(movie.ToString());
            MyConsole.PrintLine("Bye");
        }
    }
}
