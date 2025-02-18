using System.Diagnostics.CodeAnalysis;
using Library4Nick;
namespace LINQ_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ Demo");
            int[] numbers = { 0,1,2,3,4,5,6,7,8,9,10};

            var evenNumberQuery = from number in numbers 
                                  where number % 2 == 0 
                                  orderby number 
                                  descending select number;
            string evenNumbers = "";
            foreach (var number in numbers)
            {
                evenNumbers += number;
            }

            decimal[] salesTotals = new decimal[] { 1286.45m, 2433.49m, 2893.85m, 2094.53m };
            var salesList = from sales in salesTotals
                            select sales;
            decimal sum = 0.0m;
            foreach (var sales in salesTotals)
            {
                sum += sales;
            }
            MyConsole.PrintLine($"Sales: {sum.ToString()}");

            // p583
            List<Invoice> invoiceList = InvoiceDB.GetInvoices();
            foreach (var invoice in invoiceList)
            {
                MyConsole.PrintLine(invoice.ToString());
            }

            // p585
            salesList = from sales in salesTotals
                        where sales> 2000
                        select sales;
            string salesDisplay = "";
            foreach (var sales in salesList) 
                { salesDisplay += sales.ToString("c") + "|"; }
            MyConsole.Print(salesDisplay);


            //MyConsole.PrintLine("Invoices w total over $150");
            //invoices = from invoice in invoiceList
            //           where invoice.InvoiceTotal > 150
            //           select invoice;


            List<Customer> customerList = CustomerDB.GetCustomers();
            //join in LINQ
            var invoices2 = from invoice in invoiceList
                       join customer in customerList
                       on invoice.CustomerID equals customer.CustomerID
                       where invoice.InvoiceTotal >150
                       orderby customer.Name, invoice.InvoiceTotal descending
                       select new {customer.Name, invoice.InvoiceTotal};
            string invoiceDisplay = "Customer Name\t\tInvoice Amount\n";
            foreach (var invoice in invoices2)
            {
                invoiceDisplay += invoice.Name+"\t\t"+invoice.InvoiceTotal+"\n";
            }
            MyConsole.Print(invoiceDisplay);

            // p 593 - extension methods
            // list of invoice totals > 150 ordered by customerid, then descending invoicetotal
            var invoices3 = invoiceList.
                Where(i => i.InvoiceTotal > 150).
                OrderBy(i => i.CustomerID).
                ThenByDescending(i => i.InvoiceTotal).
                Select(i => new { i.CustomerID, i.InvoiceTotal });

            foreach (var i in invoices3)
            {
                MyConsole.PrintLine($"{i.CustomerID}: {i.InvoiceTotal:c}");
            }
            MyConsole.PrintLine("\nbuhbye");
        }
    }
}
