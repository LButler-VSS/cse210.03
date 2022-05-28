using System;
using System.Collections.Generic;

namespace Unit3.Game
{
    public class Parachute
    {
        private List<string> chute = new List<string>();
        private int chuteLength = 4;

        public Parachute()
        {
            chute.Add("  ___");
            chute.Add(" /___\\");
            chute.Add(" \\   /");
            chute.Add("  \\ /");
            chute.Add("   O");
            chute.Add("  /|\\");
            chute.Add("  / \\");
        }

        public void CheckChute(bool guess)
        {
            if (guess)
                return;
            else if (chuteLength == 1)
            {
                chuteLength--;
                chute.RemoveAt(0);
                chute[0] = "   X";
            }
            else
            {
                chuteLength--;
                chute.RemoveAt(0);
            }
        }

        public string GetChute()
        {
            switch (chuteLength)
            {
                case 4:
                    return ($"{chute[0]}\n{chute[1]}\n{chute[2]}\n{chute[3]}\n{chute[4]}\n{chute[5]}\n{chute[6]}\n\n^^^^^^^");
                case 3:
                    return ($"{chute[0]}\n{chute[1]}\n{chute[2]}\n{chute[3]}\n{chute[4]}\n{chute[5]}\n\n^^^^^^^");
                case 2:
                    return ($"{chute[0]}\n{chute[1]}\n{chute[2]}\n{chute[3]}\n{chute[4]}\n\n^^^^^^^");
                case 1:
                    return ($"{chute[0]}\n{chute[1]}\n{chute[2]}\n{chute[3]}\n\n^^^^^^^");
                case 0:
                    return ($"{chute[0]}\n{chute[1]}\n{chute[2]}\n\n^^^^^^^");
                default:
                    return " ";
            }
        }

        public bool Cut()
        {
            if (chuteLength == 0)
                return true;
            else
                return false;
        }
    }
}
