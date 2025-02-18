using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_App
{
    internal class WordDictionary
    {
        public string? word {  get; set; }
        public static List<string> MakeDictionary()
        {
            List<string> words = new List<string>
            {
                "apple", "banana", "car", "dog", "elephant", "flower", "house", "jump", "kite", "laugh", "moon", "night", "orange", "play",
                "quick", "river", "sun", "tree", "under", "very", "water", "xylophone", "yellow", "zebra", "anchor", "bicycle", "cloud", "dinosaur",
                "earth", "friend", "game", "hill", "ice", "jellyfish", "king", "leaf", "mountain", "new", "ocean", "pen", "queen", "rocket",
                "star", "tiger", "umbrella", "vampire", "whale", "x-ray", "yarn", "zoo", "art", "ball", "cat", "doghouse", "earthworm", "firetruck",
                "guitar", "hat", "island", "jumping", "kite", "lion", "moonlight", "noodle", "open", "parrot", "question", "rose", "sock", "turtle",
                "unicorn", "violet", "waterfall", "extra", "yellowish", "zephyr", "applepie", "badger", "carrot", "dove", "envelope", "frog",
                "grape", "hands", "interact", "joy", "kiwi", "lighthouse", "monkey", "nest", "outlook", "present", "quiz", "rocketship",
                "squirrel", "tiger", "up", "variety", "window", "xylophonist", "yawn", "zookeeper", "airplane", "button", "cloudy", "dream",
                "elephant", "fish", "goodbye", "hilltop", "iron", "jungle", "kiteboard", "lemon", "mango", "note", "overcast", "pencil", "questionable",
                "rainbow", "squirrel", "topaz", "umbrella", "violet", "wizard", "xerox", "yogurt", "zooey", "antelope", "balloon", "carousel",
                "deck", "echo", "flame", "guitar", "hornet", "icon", "jungle", "lunch", "master", "nightlight", "operation", "purple", "quest",
                "rosebud", "sand", "topple", "urgent", "vivid", "warmth", "xenon", "yellowstone", "zamboni"
            };

            return words;
        }
    }
}
