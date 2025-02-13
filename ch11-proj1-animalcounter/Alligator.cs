using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch11_proj1_animalcounter
{
    internal class Alligator : Animal, Countable
    {
        public int Count {  get; set; } 
        public int getCount()
        {
            throw new NotImplementedException();
        }

        public string getCountString()
        { 
            return $" {this.Count} alligator";
        }

        public void incrementCount()
        {
            throw new NotImplementedException();
        }

        public void resetCount()
        {
            throw new NotImplementedException();
        }
        public Alligator()
        {
        }

        public Alligator(int count) :
            base(count)
        {
            base.Count = count;
        }
    }
}
