using System.Runtime.CompilerServices;

namespace ch8_demos_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ch 8 arrays");
            // declaration of an array decimal[] totals;
            // totals = new decimal[4];
            // or in one statement: decimal[] totals = new decimal[4];

            string[] names = new string[9];
            names[0] = "Nick";
            names[1] = "Sean";
            names[2] = "Jim" ;
            names[3] = "Andy";
            names[4] = "Christian";
            names[5] = "Adrian";
            names[6] = "Celina";
            names[7] = "Heath";
            names[8] = "Joe";

            Console.WriteLine("name: " +names[0]);

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }


            decimal[] prices = { 1.99m, 2.25m, 4.45m };
            for (int i = 0;i < prices.Length; i++)
            {
                Print("i: " + i +", price: " + prices[i]);
            }

            var grades = new[] { 99, 80, 78, 45 };
            int sum = 0;
            
            for(int i = 0; i<grades.Length ; i++)
            {
                sum += grades[i];

            }
            Print("Sum: " + sum);
            Print("Avg: " + sum/grades.Length);

            string fullestname = "Robert Marley";
            for (int i = 0; i < fullestname.Length; i++)
            {
                Console.Write(fullestname[i] + "");
            }
            Print("");

            // for each loop demo ** no incrementer **

            foreach (string item in names)
            {
                Console.Write(item +" ");
            }

            // p. 239
            // 3 x 4 grid


            //                   [ X by X] grid array
            int[,] grid = new int[3, 4];
            grid[0, 0] = 1;
            grid[0, 1] = 2;
            grid[0, 2] = 3;
            grid[0, 3] = 4;
            grid[1, 0] = 5;
            grid[1, 1] = 6;
            grid[1, 2] = 7;
            grid[1, 3] = 8;
            grid[2, 0] = 9;
            grid[2, 1]= 10;
            grid[2, 2]= 11;
            grid[2, 3]= 12;

            // pirnt grid
            string gridStr = "";
            for (int i = 0; i < grid.GetLength(0); i++) {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    gridStr += grid[i, j] + "\t";
                }
                gridStr += "\n";
            };
            Print("");
            Console.WriteLine(gridStr);


            // sorts in place, meaning changing variable you are calling method on.
            Array.Sort(names);
            foreach (string name in names)
            {
                Console.WriteLine(name);    
            }
            Print("");
            {
                
            }

            Console.WriteLine("Bye");
        }
        static void Print(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
