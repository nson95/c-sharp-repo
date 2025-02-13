using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch14_inheritance_demo
{
    internal sealed class Book : Product
    {
        public string Author {  get; set; }

        public Book (string code, string description, decimal price, string author) :base(code, description, price)
        {
            Author = author;
            base.Description = description;
            base.Code = code;
            base.Price = price;
        }
        public override string GetDisplayText(string sep)
        {
            return $"{base.GetDisplayText(sep)} ({Author})";
        }
    }
}
