using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigherOrLower
{
    internal class CPUPlayer : Player


    {
        internal override void SetPlayerName()
        {
            PlayerName = "CPU";

        }

        internal override void SetSpeech()
        {
            Speech = Lang.ENG;
        }

        internal override void SetGuess()
        {
            Random rnd = new Random();
             Guess = rnd.Next(1, 101);
        }


    }
}
