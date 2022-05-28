using System;
using Unit3.Game;

namespace Unit3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;
            while (playAgain)
            {
                Director director = new Director();
                playAgain = director.StartGame();
            }
        }
    }
}
