using System;
using Library4Nick;
namespace ch17_1_productmanager
{
    internal class Program

    {
        public static List<Product> products = new List<Product>();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the product manager!\n");
            //Program that makes crud functions for products
            //products stored in product.txt

            //load products from file then make while loop
            products = ProductDB.GetProducts();
            int command = 9;
            while (command != 0)
            {
                DisplayMenu();
                command = MyConsole.PromptInt("Command: ");
                switch (command)
                {
                    case 1:
                        ListProducts();
                        break;
                    case 2:
                        AddProduct();
                        break;
                        case 3:
                        DeleteProduct();
                        break;
                    case 0:
                        break;
                    default:
                        MyConsole.PrintLine("Invalid Command. Try again.");
                        break;
                }
            }
        }

        private static void AddProduct()
        {
            MyConsole.PrintLine("\nAdd Product!");
            string code = MyConsole.PromptString("Code: ");
            string description = MyConsole.PromptString("Description: ");
            decimal price = MyConsole.PromptDecimal("Price: ");
            Product p = new Product(code, description, price);    
            products.Add(p);
            ProductDB.SaveProducts(products);
            MyConsole.PrintLine("Product added.");

        }
        private static void DeleteProduct()
        {
            MyConsole.PrintLine("\nDelete Product!");
            string code = MyConsole.PromptString("Product Code: ");
            for (int i =0; i <= products.Count; i++)
            {
                Product p = products[i];
                if (p.Code != code)
                {
                    MyConsole.PrintLine("Error, entry no longer exists.");
                }
                else
                {
                    products.Remove(p);
                    MyConsole.PrintLine($"Product {p.Code} deleted.");
                    ProductDB.SaveProducts(products);
                }
            }
            

        }

        private static void ListProducts()
        {
            MyConsole.PrintLine("\nList of Products!");
            foreach (Product p in  products)
            {
                MyConsole.PrintLine(p.ToString());
            }
        }

        static void DisplayMenu()
        {
            MyConsole.PrintLine("\nCOMMAND MENU:");
            MyConsole.PrintLine("1) List Products");
            MyConsole.PrintLine("2) Add Product");
            MyConsole.PrintLine("3) Delete Product");
            MyConsole.PrintLine("0) Exit");
        }
    }
}
