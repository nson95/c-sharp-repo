using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library4Nick;

namespace PigDiceApp
{
    public class Game
    {
        public int NumOfGames { get; set; }
        public int Score {  get; set; }
        public int HighScore { get; set; }
        public int LowScore { get; set; }




        public void PlayGame()
        {
            int Tries = MyConsole.PromptInt("How many times would you like to play? ");
            int turns = 0;
            int score = 0;
            int numRolls = 0;
            while (turns < Tries)
            {
                int[,] scores = new int[2,Tries];
                Random randy = new Random();
                int roll = randy.Next(1, 7);
                if (roll == 1) {
                    score += roll;
                    numRolls++;
                    scores.SetValue(score, numRolls);
                    MyConsole.PrintLine($"Score is: {score}");
                    roll = randy.Next(1, 7);
                    turns++;
                }
                  else 
                {
                    numRolls++;
                    score += roll;
                    roll = randy.Next(1, 7);

                }
                
                MyConsole.Print($"");
            
            }
        }
    }
}
