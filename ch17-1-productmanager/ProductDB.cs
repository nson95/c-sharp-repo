using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch17_1_productmanager
{
    internal class ProductDB
    {
        private const string Dir = @"C:\C#\Files\";
        private const string Path = Dir + "Product.txt";
        private const string Sep = "|";

        public static void SaveProducts(List<Product> products)
        {
            using
            StreamWriter streamWriter = new StreamWriter(new FileStream(Path, FileMode.Create, FileAccess.Write));
            foreach (Product product in products)
            {
                streamWriter.Write(product.Code + Sep);
                streamWriter.Write(product.Description + Sep);
                streamWriter.Write(product.Price);
            }

            //streamWriter.Close();  eliminated by using statement
        }
        public static List<Product> GetProducts()
        {
            using StreamReader reader = new(new FileStream(Path, FileMode.Open, FileAccess.Read));
            List<Product> products = new List<Product>();
            while (reader.Peek() != -1)
            {
                string row = reader.ReadLine();
                string[] collumns = row.Split(Sep);

                if (collumns.Length == 3)
                {
                    string code = collumns[0];
                    string description = collumns[1];
                    decimal price = Decimal.Parse(collumns[2]);
                    Product p = new Product(code, description, price);
                    products.Add(p);
                }
            }
                return products;
        }
    }
}
