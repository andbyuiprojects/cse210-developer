using System;

namespace Unit02.Hilo
{
    public class Card
    {
        public int _cardNumber = 0;
        
        /// <summary>
        /// Constructs a new instance of Card.
        /// </summary>
        public Card()
        {

        }
        /// <summary>
        /// Generates a new random value for the card number.
        ///(The face card value/number)
        /// </summary>
        public void Draw()
        {
            Random random = new Random();
            _cardNumber = random.Next(1,14);
        }

    }

}