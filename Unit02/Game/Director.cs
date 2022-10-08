using System;
using System.Collections.Generic;

namespace Unit02.Hilo
{
    public class Director
    {
        List<Card> _cards = new List<Card>();
        bool _isPlaying = true;
        int _totalScore = 300;
        int _correctGuess = 100;
        int _wrongGuess = -75;

        int currentCard;
        int newCard;

        public Director()
        {
            for (int i = 0; i < 1; i++)
            {
                Card card = new Card();
                _cards.Add(card);
            }
        }

        public void StartGame()
        {
            while (_isPlaying)
            {
                DoOutputs();
                isPlaying();
            }
        }

        public void DoOutputs()
        {
             if (!_isPlaying)
            {
                return;
            }

            foreach (Card card in _cards)
            {
                card.Draw();
                currentCard = card._cardNumber;
            }

            foreach (Card card in _cards)
            {
                card.Draw();
                newCard = card._cardNumber;
            }

            Console.WriteLine($"The current card is: {currentCard}");
            Console.Write("Higher or Lower? [h/l] ");
            string userGuess = Console.ReadLine();

            Console.WriteLine($"You drew: {newCard}");

            if (userGuess.ToLower() == "h" && currentCard < newCard)
            {
                _totalScore += _correctGuess;
            }
            else if (userGuess.ToLower() == "l" && currentCard > newCard)
            {
                _totalScore += _correctGuess;
            }
            else if (userGuess.ToLower() == "h" && currentCard > newCard)
            {
                _totalScore += _wrongGuess;
            }
            else if (userGuess.ToLower() == "l" && currentCard < newCard)
            {
                _totalScore += _wrongGuess;
            }
            
        }
    

        public void isPlaying()
        {
            Console.WriteLine($"Your current score is: {_totalScore}");
            
            if (_totalScore == 0)
            {
                _isPlaying = false;
            }

            if (!_isPlaying)
            {
                return;
            }

            currentCard = newCard;
            Console.Write("Do you want to play again? [y/n] ");
            string drawCard = Console.ReadLine();
            _isPlaying = (drawCard.ToLower() == "y");
        }

    }

}