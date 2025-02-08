namespace ch9_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintLine("Welcome to the Dates and times demo");
            // whats the current date and time
            DateTime currentDateTime = DateTime.Now;
            DateTime today = DateTime.Today;
            Print("Todays date is: " + today.ToString());

            // string interpolation

            Print($"Todays date is: {today}");
            Print($"longtime: {today.ToLongDateString()}");
            Print($"It is : {today.Month}");

            // p 281 math with dates and times
            DateTime dueDate = currentDateTime.AddMonths(2);

            DateTime halloween = new DateTime(2025, 10, 31);
        }

        //loop through string in sentence
        // string.indexof
        string sentence = "omg a real sentence example";
        foreach (char a in sentence) {

            }

        
    static void Print(string msg)
        {
            Console.Write(msg);
        }

        static void PrintLine(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
