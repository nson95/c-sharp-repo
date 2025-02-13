using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library4Nick;

namespace ch10_proj2_personmanager.Model
{
    internal class Person
    {
        string FirstName { get; set; }
        string LastName { get; set; }

        public Person() { }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public virtual string ToString()
        {
            return $"Name: {FirstName} {LastName}";
        }
    }
}
