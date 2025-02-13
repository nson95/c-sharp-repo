using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ch14_inheritance_demo
{
    public abstract class Product
    {                       
        public string Code { get; set; }    
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Product ()
        {

        }
        public Product(string Code, string Description, decimal Price)
        {
            this.Code = Code;
            this.Description = Description;
            this.Price = Price;
        }
        // virtual keyword can be used to designate
        public virtual string GetDisplayText(string sep) {
            return $"{Code}{sep}{Price.ToString("c")}{sep}{Description}";
        }
    }
}
