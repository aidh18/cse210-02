using System;


namespace cse210_02.Game
{
    public class Card
    {
        public int value = 0;

        public Card()
        {
        }

        public void Draw()
        {
            Random randomNum = new Random();
            value = randomNum.Next(1, 13);

        }

    }
}