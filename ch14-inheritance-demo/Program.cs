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


            // abstract class is a class that cannot be instantiated, must be inherited
            // sealed class cannot be inherited.

            // polymorphism allows you to treat objects of different types as if they were the same type
            // by referring to a base calss that is common to both objects


            Movie movie = new Movie(1, "Test", 2008, "M", "Favreau");
            //Product p1 = new Product("C#", "Murach's C# Book", 88.99m);
            //MyConsole.Print(p1.GetDisplayText("|"));
            MyConsole.Print(movie.ToString());

            Book b1 = new Book("java", "Murach's Java", 88.99m, "Joel Murach");
            Software s1 = new Software("vs", "VisualStudio", 99.88m, "22");
            Book b3 = new Book("andr", "Murach's Android", 78.99m, "Joel Murach");
            List<Product> products = new List<Product>();
            products.Add(b1);
            products.Add(b3);
            products.Add(s1);

            foreach (Product p in products)
            {
                MyConsole.Print(p.GetDisplayText("|"));
            }
            MyConsole.PrintLine("Bye");
        }
    }
}
