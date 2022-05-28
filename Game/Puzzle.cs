using System;
using System.IO;
using System.Linq;

namespace Unit3.Game
{
    public class Puzzle
    {
        private string path = @"F:\School\CSE 210\Projects\Unit3\bin\Debug\net5.0\words.txt";
        Random rng = new Random();
        private string word;

        public void SetWord()
        {
            int line = rng.Next(12947) - 1;
            word = File.ReadLines(path).Skip(line).Take(1).First();
            Console.WriteLine($"{word}, {line + 1}");
        }
    }
}
