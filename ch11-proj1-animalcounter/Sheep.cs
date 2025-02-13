namespace ch11_proj1_animalcounter
{
    internal class Sheep : Animal, Countable
    {
        public string Name { get; set; }  

        public string getCountString()
        {
            return $" {this.Count} {this.Name}";
        }

        public void incrementCount()
        {
            throw new NotImplementedException();
        }

        public void resetCount()
        {
            throw new NotImplementedException();
        }

        public Sheep(int count, string name)
        {
            base.Count = count;
            Name = name;  
        }
    }
}
