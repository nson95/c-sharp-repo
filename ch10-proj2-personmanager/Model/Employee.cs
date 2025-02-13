using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch10_proj2_personmanager.Model
{
    internal class Employee : Person
    {
        public string SocialSecNum { get; set; }
        public Employee() { }

        public Employee(string firstName, string lastName, string socialSecNum) :
            base(firstName, lastName){
            SocialSecNum = socialSecNum;

        }
    public override string ToString()
        {
            string ssnMasked = "xxx-xx-" + SocialSecNum.Substring(7);
            return $"{base.ToString()} Social Sec Number: {SocialSecNum}";
        }
    }

}
