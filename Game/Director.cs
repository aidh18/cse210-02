using System;
using System.Collections.Generic;


namespace Unit02.Game
{
    /// <summary>
    /// A person who directs the game. 
    ///
    /// The responsibility of a Director is to control the sequence of play.
    /// </summary>
    public class Director
    {
        List<Card> cards = new List<Card>();
        bool isPlaying = true;
        int score = 0;
        int totalScore = 0;

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
            for (int i = 0; i < 5; i++)
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
            while (isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// Asks the user if they want to roll.
        /// </summary>
        public void GetInputs()
        {
            Console.Write("Play game? [y/n] ");
            string card = Console.ReadLine();
            isPlaying = (rollDice == "y");
        }

        /// <summary>
        /// Updates the player's score.
        /// </summary>
        public void DoUpdates()
        {
            if (!isPlaying)
            {
                return;
            }

            score = 0;
            foreach (Card card in cards)
            {
                die.Roll();
                score += die.points;
            }
            totalScore += score;
        }

        /// <summary>
        /// Displays the dice and the score. Also asks the player if they want to roll again. 
        /// </summary>
        public void DoOutputs()
        {
            if (!isPlaying)
            {
                return;
            }

            string values = "";
            foreach (Die die in dice)
            {
                values += $"{die.value} ";
            }

            Console.WriteLine($"You rolled: {values}");
            Console.WriteLine($"Your score is: {totalScore}\n");
            isPlaying = (score > 0);
        }
    }
}


