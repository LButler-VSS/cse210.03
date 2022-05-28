using System;


namespace Unit3.Game
{
    public class Director
    {
        Puzzle puzzle = new Puzzle();
        public void StartGame()
        {
            puzzle.SetWord();
        }
    }
}
