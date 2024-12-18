using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigherOrLower
{
     class HumanPlayer : Player
    {
        
        internal override void SetPlayerName()
        {
            Dialogue.AskName(this.Speech);
            PlayerName = Console.ReadLine();

        }

        internal override void SetSpeech()
        {
            Dialogue.AskLang();
            string Lang = Console.ReadLine();
            if (Lang == "FRN" || Lang == "2")
            {
                Speech = HigherOrLower.Lang.FRN;
            }

            else
            {

                Speech = HigherOrLower.Lang.ENG;
            }
        
        }

        internal override void SetGuess()
        {
            Dialogue.AskGuess(this.Speech);
            Guess = int.Parse(Console.ReadLine());
            
        }


    }
}
