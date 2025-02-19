using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_App
{
    internal class WordDictionary
    {
        public static Random randy = new Random(); 
        public string? word {  get; set; }
        public static string GetRandomWord()
        {
            string randomWord = "";
            List<string> words = new List<string>
            {

                           "apple", "ball", "cat", "dog", "elephant", "fish", "grape", "hat", "ice", "jump",
                    "kite", "lemon", "moon", "nose", "orange", "pen", "quick", "rain", "sun", "tree",
                    "umbrella", "violet", "whale", "x-ray", "yellow", "zebra", "air", "blue", "cloud",
                    "duck", "egg", "farm", "goat", "hill", "ink", "jelly", "kite", "leaf", "mouse",
                    "night", "open", "play", "quiet", "rocket", "star", "toy", "unit", "van", "wind",
                    "xylophone", "yarn", "zoo", "ant", "balloon", "candle", "doll", "elephant", "fishbowl",
                    "guitar", "happy", "icecream", "jellyfish", "key", "lamp", "moonlight", "nut", "owl",
                    "pencil", "question", "rose", "snow", "treehouse", "up", "vampire", "water", "xmas",
                    "yellowish", "zooey", "act", "bat", "clown", "door", "even", "fly", "giraffe", "hop",
                    "inch", "joy", "kangaroo", "lemonade", "mask", "noodles", "ocean", "pizza", "quilt",
                    "rainbow", "sock", "tent", "under", "very", "watch", "x-ray", "yarn", "zipper",
                    "applepie", "ballerina", "catfish", "dove", "elephant", "flower", "garden", "hat",
                    "island", "jumping", "keyhole", "laugh", "mango", "necklace", "octopus", "plum",
                    "quack", "road", "snowflake", "turtle", "underwater", "vacuum", "wet", "xenon",
                    "yellowstone", "zigzag", "airplane", "boat", "chicken", "duckling", "eggplant",
                    "fence", "green", "hug", "island", "jellybean", "koala", "lighthouse", "moonbeam",
                    "notebook", "puddle", "queen", "rockstar", "snowman", "toybox", "unicorn", "violet",
                    "watch", "xylophonist", "yellowtail", "zamboni", "acorn", "breeze", "cactus", "dust",
                    "elbow", "feather", "goggles", "hugging", "ignition", "juice", "king", "lion", "muffin",
                    "noodle", "oatmeal", "pen", "quince", "rosebud", "sock", "teardrop", "ufo", "vulture",
                    "wrench", "xenopus", "yoga", "zone"
            };
            randomWord = words[randy.Next(1, 151)];

            return randomWord;
        }
        public static string GetHiddenWord(string word)
        {
            string hiddenWord = "";
            foreach (char c in word)
            {
                hiddenWord += "_";
            }
            return hiddenWord;
        }
    }
}
