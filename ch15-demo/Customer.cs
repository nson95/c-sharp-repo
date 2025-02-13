
using System.Diagnostics;

namespace ch15_demo
{
    internal class Customer : Summarizable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CustomerNumber { get; set; }

        public Customer(string firstName, string lastName, string customerNumber)
        {
            FirstName = firstName; 
            LastName = lastName;
            CustomerNumber = customerNumber;
        }

        public string GetSummaryDetails()
        {
            string summary = $"Cusrtomer: {LastName}, {FirstName} | {CustomerNumber}";
            return summary;
        }
    }
}
