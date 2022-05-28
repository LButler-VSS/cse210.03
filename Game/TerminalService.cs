using System;

namespace Unit3.Game
{
    public class TerminalService
    {
        public TerminalService()
        {
        }

        public string ReadText(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        public void WriteText(string prompt)
        {
            Console.WriteLine(prompt);
        }
    }
}
