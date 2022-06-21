using System;


namespace Jumper.Game
{
    public class Word
    {

        
        public Word()
        {
        }

        public void Draw()
        {
            Random randomNum = new Random();
            value = randomNum.Next(1, 13);
            Name();
        }


        }


    }
}