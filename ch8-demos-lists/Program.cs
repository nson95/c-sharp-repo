namespace ch8_demos_lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the list demo!");
            Random randy = new Random();
            int dieRoll = randy.Next(1, 7);


            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);

            foreach (int i in numbers)
            {
                Console.Write(i);
            }
            Console.WriteLine("");
            List<string> names = new List<string>();
            names.Add("Jim");
            names.Add("Andy");
            names.Add("Nick");
            names.Add("Christian");
            names.Add("Adrian");
            names.Add("Joe");
            names.Add("Celina");
            names.Add("Heath");
            names.Add("Sean");

            names.Insert(names.Count / 2, "Test");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("Adrian? " +names.Contains("Adrian"));

            Console.WriteLine("Celina in position: " + names.BinarySearch("Celina"));
            Console.WriteLine("Celina in position: " + names.IndexOf("Celina"));

            Console.WriteLine("Bye");
        }
    }
}
