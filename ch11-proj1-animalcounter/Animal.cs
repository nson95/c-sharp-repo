using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch11_proj1_animalcounter
{
    public abstract class Animal
    {
        public int Count {  get; set; }

        public Animal() { }
        public Animal(int count)
        {
            this.Count = count;
        }
    }
}
