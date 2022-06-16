using System;


namespace cse210_02.Game
{
    public class Card
    {
        public int value = 0;
        public string name;

        public Card()
        {
        }

        public void Draw()
        {
            Random randomNum = new Random();
            value = randomNum.Next(1, 13);
            Name();
        }

        public string Name()
        {
            switch(value)
            {
                case 1:
                    name = "Ace";
                    break;

                case 11:
                    name = "Jack";
                    break;

                case 12:
                    name = "Queen";
                    break;


                case 13:
                    name = "King";
                    break;

                default:
                    name = value.ToString();
                    break;

            }


            return name;
        }


    }
}