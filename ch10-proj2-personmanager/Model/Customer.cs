using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch10_proj2_personmanager.Model
{
    internal class Customer : Person
    {
        public string CustomerNumber { get; set; }

        public Customer() { }
        public Customer(string firstName, string lastName, string customerNumber) :
            base(firstName, lastName)
        {
            CustomerNumber = customerNumber;
        }
        public override string ToString()
        {
            return $"{base.ToString()} Customer number: {CustomerNumber}";
        }
    }
}
