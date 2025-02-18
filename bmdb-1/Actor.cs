using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bmdb_1
{
    internal class Actor
    {   
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        public int? BirthDay { get; set; } 
        public Actor()
        {

        }
        public Actor(string firstname, string lastname, string gender, int birthday) { 
            FirstName = firstname;
            LastName = lastname;
            Gender = gender;
            BirthDay = birthday;
        }
    }
}
