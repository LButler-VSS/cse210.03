using System;

namespace Unit3.Game
{
    public class TerminalService
    {
        public TerminalService()
        {
        }

        public char Read(string prompt)
        {
            Console.WriteLine(prompt);
            char guess = char.Parse(Console.ReadLine());
            return guess;
        }

        public void Print(string prompt)
        {
            Console.WriteLine("");
            Console.WriteLine(prompt);
        }


    }
}
