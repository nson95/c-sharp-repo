namespace ch2_ex3_rectangle_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Rectangle Calc App");

            Console.Write("Enter Length: ");
            double length = Double.Parse(Console.ReadLine());
            Console.Write("Enter Width: ");
            double width = Double.Parse(Console.ReadLine());

            double area = length * width;
            double perimeter = 2 * length + 2 * width;

        }
    }
}
