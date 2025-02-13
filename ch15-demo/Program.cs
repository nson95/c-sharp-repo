
using Library4Nick;

namespace ch15_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to interfaces!\n");

            //class can extend one and only one class, but can implement multiple interfaces.
            // the implementation for the members of an interface must be included in any class that implements the interface
            // p 493 common interfaces
            Product p1 = new Product("C#", "a description of a book", 3.50m);
            Product p2 = new Product("Java", "poo", 99.99m);
            Product p3 = new Product("SQL", "a butt", 66.50m);
            List<Summarizable> things = new List<Summarizable>();
            Customer c1 = new Customer("Adrian", "Johnson", "AJ001");
            Customer c2 = new Customer("Celina", "Saksith", "CS002");
            Customer c3 = new Customer("Andy", "Farmer", "AF001");
            things.Add(p1);
            things.Add(p2);
            things.Add(p3);
            things.Add(c1);
            things.Add(c2);
            things.Add(c3);
            foreach (Summarizable summarizable in things)
            {
                MyConsole.PrintLine(summarizable.GetSummaryDetails());
            }
            List<Product> products = new List<Product>();
            products.Add(p1);
            products.Add(p2);
            products.Add(p3);
            MyConsole.PrintLine("=== All Products ===");
                products.Sort();
            foreach (Product product in products)
            {
                MyConsole.PrintLine(product.GetSummaryDetails());
            }

        }
    }
}
