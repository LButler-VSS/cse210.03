using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Unit3.Game
{
    public class Puzzle
    {
        private string path = @"F:\School\CSE 210\Projects\Unit3\bin\Debug\net5.0\words.txt";
        Random rng = new Random();
        private string word;
        private List<char> guessed = new List<char>();
        private bool correctGuess = false;
        
        public Puzzle()
        {
            guessed.Add('_');
            guessed.Add('_');
            guessed.Add('_');
            guessed.Add('_');
            guessed.Add('_');

            SetWord();
        }

        public void SetWord()
        {
            int line = rng.Next(12947) - 1;
            word = File.ReadLines(path).Skip(line).Take(1).First();
            Console.WriteLine($"{word}, {line + 1}");
        }

        public void CheckGuess(char guess)
        {
            int position = -1;
            correctGuess = false;
            foreach (char c in word)
            {
                position++;
                if (c == guess)
                {
                    guessed[position] = guess;
                    correctGuess = true;
                }
            }
        }

        public string GetGuess()
        {
            return ($"{guessed[0]} {guessed[1]} {guessed[2]} {guessed[3]} {guessed[4]}");
        }

        public bool ResolveChute()
        {
            return correctGuess;
        }

        public bool Solved()
        {
            if (($"{guessed[0]}{guessed[1]}{guessed[2]}{guessed[3]}{guessed[4]}") == word)
            { 
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
