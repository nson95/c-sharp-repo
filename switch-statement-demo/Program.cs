namespace switch_statement_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string action = "noexit";
            Console.WriteLine("Hello, World!");
            while (action != "exit")
            {
                Console.WriteLine("menu: ");
                Console.WriteLine("========");
                Console.WriteLine("GID: ");
                Console.WriteLine("Add: ");
                Console.WriteLine("Update: ");
                Console.WriteLine("Delete: ");
                Console.WriteLine("menu: ");

            }

            //customertype determines discpct
            //"r" - 10%
            // "c" - 20%
            // else - 0%
            string custType = "r";
            decimal discPct = 0.0m;

            discPct = custType switch
            {
                "R" => .1m,
                "C" => .2m,
                _ => 0m
            };
            Console.WriteLine(discPct + " is discount percent");

            // p. 151 conditional experssion/ turnary operator
            // day of week to weekday/weekend converter
            int dayOfWeek = 4;

            // define var  = against boolean  ? if true set to : if false set to
            string msg = (dayOfWeek <= 5) ? "weekday" : "weekend";

            Console.WriteLine("bye");
        }
    }
}
