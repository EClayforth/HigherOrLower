using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigherOrLower
{
    internal abstract class Player
    {
        internal string PlayerName {  get; set; }
        internal Lang Speech {  get; set; }
        internal int Guess {  get; set; }
        internal int MovesLeft { get; set; }
        internal bool PlayAgain { get; set; }

        

        protected Player()
        {
            SetSpeech();
            SetPlayerName();
            this.PlayAgain = true;
            

        }


        internal abstract void SetGuess();

        internal abstract void SetSpeech();

        internal abstract void SetPlayerName();


        internal virtual void SetMovesLeft()
        {
            MovesLeft = 5;
        }

        internal virtual void ReduceMovesLeft()
        {
            MovesLeft = MovesLeft - 1 ;
        }

        internal virtual void ZeroMovesLeft()
        {
            MovesLeft = 0;
        }
        

        internal virtual void EndPLayAgain(){

            PlayAgain = false;
        }
    }
}
