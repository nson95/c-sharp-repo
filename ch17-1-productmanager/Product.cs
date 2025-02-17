namespace ch17_1_productmanager
{
    internal class Product
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Product(string code, string description, decimal price)
        {
            Code = code;
            Description = description;
            Price = price;
        }
        public override string ToString()
        {
            return $"Code: ({Code})- ({Description}) {Price:c}";
        }
    }
}
