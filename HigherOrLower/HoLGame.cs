using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigherOrLower
{
    internal class HoLGame
    {
        internal HoLGame()
        {
            Dialogue.WelcomeMessage();

            HumanPlayer player1 = new HumanPlayer();

            CPUPlayer player2 = new CPUPlayer();

            GameMechanics gameMechanics1= new GameMechanics();

            while (player1.PlayAgain)
            {
                gameMechanics1.Round(player1, player2);

                gameMechanics1.PlayAgain(player1);
            }

            Dialogue.EndGameMessage(player1.Speech);



        }
    }
}
