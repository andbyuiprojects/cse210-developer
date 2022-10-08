using System;

namespace Unit02.Hilo
{
    public class Card
    {
        public int _cardNumber = 0;

        public Card()
        {

        }

        public void Draw()
        {
            Random random = new Random();
            _cardNumber = random.Next(1,14);
        }

    }

}