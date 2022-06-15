using System;
using System.Collections.Generic;


namespace cse210_02.Game
{
    // <summary>
    // A person who directs the game. 
    //
    // The responsibility of a Director is to control the sequence of play.
    // </summary>
    public class Director
    {
        // List<Card> deck = new List<Card>();
        bool isPlaying = true;
        int score = 0;
        int totalScore = 0;

        // <summary>
        // Constructs a new instance of Director.
        // </summary>
        public Director()
        {
            Card card = new Card();
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
            string flipCard = Console.ReadLine();
            isPlaying = (flipCard == "y");
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

            score = 300;
            foreach (Card card in cards)
            {
                card.Draw();
                score += card.points;
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
            foreach (Card card in Cards)
            {
                values += $"{card.value} ";
            }

            Console.WriteLine($"You rolled: {values}");
            Console.WriteLine($"Your score is: {totalScore}\n");
            isPlaying = (score > 0);
        }
    }
}


