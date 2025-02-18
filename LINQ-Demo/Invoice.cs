namespace LINQ_Demo;

public class Invoice
{
    public int InvoiceID { get; set; }
    public int CustomerID { get; set; }
    public DateTime InvoiceDate { get; set; }
    public decimal ProductTotal { get; set; }
    public decimal SalesTax { get; set; }
    public decimal Shipping { get; set; }
    public decimal InvoiceTotal { get; set; }
       public override string ToString()
    {
        return $"Invoice: ({InvoiceID})|{CustomerID}|{InvoiceDate}|{ProductTotal:c}|{SalesTax:p2}|{Shipping:c}|{InvoiceTotal:c}";
    }
}
