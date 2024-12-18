using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigherOrLower
{
    internal class GameMechanics
    {
        internal virtual void Round(Player player1, Player player2)
        {

            player2.SetGuess();
            player1.SetMovesLeft();
            Rez Result = new Rez();


            while (player1.MovesLeft > 0)
            {
                player1.SetGuess();
                ResolveGuess(player1, player2 );
                player1.ReduceMovesLeft();
                Dialogue.MovesLeftMessage(player1);
            }

            if (player1.Guess != player2.Guess)
            {
                Dialogue.LossMessage(player1, player2);
            }
        }
     

        internal virtual void ResolveGuess(Player player1, Player player2)

        {
            if (player1.Guess == player2.Guess)
            {
                Dialogue.WinMessage(player1);
                player1.ZeroMovesLeft();
            }
            else if (player1.Guess < player2.Guess)
            {
                Dialogue.HigherMessage(player1.Speech);

            }
            else 
            {
                Dialogue.LowerMessage(player1.Speech);
            }
        }
        internal virtual void PlayAgain(Player player1)
        {
            Dialogue.PlayAgain(player1.Speech);
            string ans = Console.ReadLine();
                if (ans == "n")
            {
                player1.EndPLayAgain();
            }
        }

        }
    } 

