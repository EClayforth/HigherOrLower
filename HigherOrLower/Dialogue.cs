using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigherOrLower
{
    internal class Dialogue
    {
        internal static void WelcomeMessage()
        {

            Console.WriteLine("Welcome to higher or lower!!");
        }

        internal static void AskLang()
        {
            Console.WriteLine("What language do you speak? 1:ENG /2:FRN");
        }

        internal static void AskName(Lang Speech)
        {
            if (Speech == Lang.FRN)
            {
                Console.WriteLine("Quel est ton nom?");
            }
            else
            {
                Console.WriteLine("What is your name?");
            }
        }

        internal static void AskGuess(Lang Speech)
        {
            if (Speech == Lang.FRN)
            {
                Console.WriteLine("Quel numéro devinez-vous ?");
            }
            else
            {

                Console.WriteLine("What number do you guess?");
            }
        }

        internal static void EndGameMessage(Lang Speech)
        {
            if (Speech == Lang.FRN)
            {
                Console.WriteLine("Merci d'avoir joué");
            }
            else
            {

                Console.WriteLine("Thanks For Playing!!");
            }


        }

        internal static void WinMessage(Player player1)
        {
            if (player1.Speech == Lang.FRN)
            {
                Console.WriteLine("tu as gagné " + player1.PlayerName + " !! ");
            }
            else
            {

                Console.WriteLine("You have won " + player1.PlayerName + "!! ");
            }

        }

        internal static void HigherMessage(Lang Speech)
        {

            if (Speech == Lang.FRN)
            {
                Console.WriteLine("Trop bas");
            }
            else
            {

                Console.WriteLine("Too Low");
            }
        }

        internal static void LowerMessage(Lang Speech)
        {
            if (Speech == Lang.FRN)
            {
                Console.WriteLine("Trop haut");
            }
            else
            {

                Console.WriteLine("Too High");
            }

        }

        internal static void PlayAgain(Lang Speech)
        {
            if (Speech == Lang.FRN)
            {
                Console.WriteLine("Voulez-vous rejouer? o/n");
            }
            else
            {

                Console.WriteLine("Would you like to play again ? y/n");
            }

        }

        internal static void LossMessage(Player player1, Player player2)
        {
            if (player1.Speech == Lang.FRN) {
                Console.WriteLine("Désolé, vous avez perdu mon numéro " + player2.Guess);

            }
            else
            {

                Console.WriteLine("Sorry you have lost my number was " + player2.Guess);

            }

        }

        internal static void MovesLeftMessage(Player player1)
        {
            if (player1.Speech == Lang.FRN)
            {
                Console.WriteLine(" Il vous reste" + player1.MovesLeft + " coups");

            }
            else
            {

                Console.WriteLine("You have  " + player1.MovesLeft + " moves remaining");

            }


        }


    }
} 
