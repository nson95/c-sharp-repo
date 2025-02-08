namespace ch8_proj2_sales_report_proj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Sales Report Application");
            Console.WriteLine();




            Console.WriteLine("Region\tQ1\t\tQ2\t\tQ3\t\tQ4");
            decimal [,] sales = { {1540.0m, 2010.0m, 2450.0m, 1845.0m},
                                {1130.0m, 1168.0m, 1847.0m, 1491.0m},
                                {1580.0m, 2305.0m, 2710.0m, 1284.0m},
                                {1105.0m, 4102.0m, 2391.0m, 1576.0m} };
            for (int i = 0; i < sales.GetLength(0); i++)
            {
                Console.Write((i + 1) + "\t");
                for (int j = 0; j < sales.GetLength(1); j++)
                {
                    Console.Write(sales[i,j].ToString("c") + "\t");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
            Console.WriteLine("Sales by Region: ");
            for (int i = 0; i < sales.GetLength(0); i++)
            {
                Console.Write("Region "+(i + 1) + ": ");
                decimal sum = 0.0m;
                for (int j = 0; j < sales.GetLength(1); j++)
                {
                    sum += sales[i, j];
                    Console.Write(sales[i, j].ToString("c") + "\t");
                }
                Console.WriteLine(sum.ToString("c"));
            }
            Console.WriteLine("");

            Console.WriteLine("Goodbye lil bit");

        }
    }
}
