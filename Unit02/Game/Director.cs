using System;
using System.Collections.Generic;

namespace Unit02.Hilo
{
    /// <summary>
    /// A person who directs the game. 
    ///
    /// The responsibility of a Director is to control the sequence of play.
    /// </summary>
    public class Director
    {
        List<Card> cards = new List<Card>();
        bool stillPlaying = true;
        int totalScore = 300;
        int correctGuess = 100;
        int wrongGuess = -75;

        int currentCard;
        int newCard;

        /// <summary>       
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
            for (int i = 0; i < 1; i++)
            {
                Card card = new Card();
                cards.Add(card);
            }
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            while (stillPlaying)
            {
                DoOutputs();
                isPlaying();
            }
        }

        /// <summary>
        /// Begins the game by asking the user what their guess is. does math for 
        /// correct or incorrect guess and adds it to the total score.
        /// </summary>
        public void DoOutputs()
        {
             if (!stillPlaying)
            {
                return;
            }

            foreach (Card card in cards)
            {
                card.Draw();
                currentCard = card.cardNumber;
            }

            foreach (Card card in cards)
            {
                card.Draw();
                newCard = card.cardNumber;
            }

            Console.WriteLine($"The current card is: {currentCard}");
            Console.Write("Higher or Lower? [h/l] ");
            string userGuess = Console.ReadLine();

            Console.WriteLine($"You drew: {newCard}");

            if (userGuess.ToLower() == "h" && currentCard < newCard)
            {
                totalScore += correctGuess;
            }
            else if (userGuess.ToLower() == "l" && currentCard > newCard)
            {
                totalScore += correctGuess;
            }
            else if (userGuess.ToLower() == "h" && currentCard > newCard)
            {
                totalScore += wrongGuess;
            }
            else if (userGuess.ToLower() == "l" && currentCard < newCard)
            {
                totalScore += wrongGuess;
            }
            
        }
    
        /// <summary>
        /// Displays the score. Also asks the player if they want to play again.
        /// Also checks to see it score is 0 to end game.
        /// </summary>
        public void isPlaying()
        {
            Console.WriteLine($"Your current score is: {totalScore}");
            
            if (totalScore == 0)
            {
                stillPlaying = false;
            }

            if (!stillPlaying)
            {
                return;
            }

            currentCard = newCard;
            Console.Write("Do you want to play again? [y/n] ");
            string drawCard = Console.ReadLine();
            stillPlaying = (drawCard.ToLower() == "y");
        }

    }

}