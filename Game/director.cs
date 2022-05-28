using System;


namespace Unit3.Game
{
    public class Director
    {
        private Puzzle puzzle = new Puzzle();
        private bool isPLaying = true, playAgain = true;
        private TerminalService terminalService = new TerminalService();
        private Parachute parachute = new Parachute();
        
        public bool StartGame()
        {
            while (isPLaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
            return playAgain;
        }

        private void GetInputs()
        {
            char guess = terminalService.Read("\nGuess a letter [a-z]: ");
            puzzle.CheckGuess(guess);
        }

        private void DoUpdates()
        {
            parachute.CheckChute(puzzle.ResolveChute());
        }

        private void DoOutputs()
        {
            string guess = puzzle.GetGuess();
            terminalService.Print(guess);
            string chute = parachute.GetChute();
            terminalService.Print(chute);
            if (puzzle.Solved())
            {
                char playAgainChar = terminalService.Read("You Won! Would you like to play again? [y/n]: ");
                if (playAgainChar == 'y')
                    playAgain = true;
                else
                    playAgain = false;
                isPLaying = false;
            }
            else if (parachute.Cut())
            {
                char playAgainChar = terminalService.Read("Sorry, you lost. Would you like to play again? [y/n]: ");
                if (playAgainChar == 'y')
                    playAgain = true;
                else
                    playAgain = false;
                isPLaying = false;
            }
            else
                isPLaying = true;

            if (!playAgain)
                terminalService.Print("Thanks for Playing!");
        }
    }
}
