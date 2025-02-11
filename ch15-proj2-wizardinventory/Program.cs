using System.Collections;

namespace ch15_proj2_wizardinventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Wizard Inventory Game");
            ArrayList menu = new ArrayList();
            menu.Add("Show - ");
            menu.Add("Show all items");
            menu.Add("Grab - ");
            menu.Add("Grab an items");
            menu.Add("Edit - ");
            menu.Add("Edit an items");
            menu.Add("Drop - ");
            menu.Add("Drop an items");
            menu.Add("Exit - ");
            menu.Add("Exit program");


            foreach (string i in menu)
            {
                Console.WriteLine(i);
            }

            void AddItem(string prompt)
            {
                string item = "";
                Console.Write(prompt);
                if (!String.IsNullOrEmpty(Console.ReadLine()))
                {
                    Console.WriteLine("Error, you must type a valid item for inventory.");
                }
                else
                {
                    item = Console.ReadLine();
                }
                menu.Add(item);
            }

                 
        }
    }
}
