using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch7_proj4_dicerollerapp
{
    public class Die
    {
        public static int DieRoll { get; set; }
        public static int DieRoll2 { get; set; }

        public Die()
        {
        }
        public Die(int FirstRoll, int SecondRoll)
        {
            FirstRoll = DieRoll;
            SecondRoll = DieRoll2;
        }
        public static string ToString()
        {
            string retStr = $"Die 1: {DieRoll}\n" +
                $"Die 2: {DieRoll2}\n" +
                $"Total: " +(DieRoll+DieRoll2)
                +"\n";
            if (DieRoll+DieRoll2 ==12)
            {
                retStr += "Box Cars!";
            }
            else if (DieRoll+DieRoll2 ==2){
                retStr += "Snake Eyes!";
            }

            return retStr;
        }
        public int RollOfDice()
        {
            Random randy = new Random();
            int result = randy.Next(1, 7);
            return result;
        }
    }
}
