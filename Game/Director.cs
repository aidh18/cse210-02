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
        int score = 300;
        int totalScore = 300;
        Card card = new Card();
        bool guessIsHigher = false;

        // <summary>
        // Constructs a new instance of Director.
        // </summary>
        public Director()
        {
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
            // Ask user to play again.
            Console.Write("\nPlay again? [y/n] ");

            // If the users says no end game.
            isPlaying = (Console.ReadLine() == "y");

            if (!isPlaying) {
                return;
            }

            // Print value so that user can make a guess.
            Console.WriteLine($"The card is: {card.value}.");

            // GET guess.
            Console.Write("Higher or lower? [h/l] ");            
            guessIsHigher = (Console.ReadLine() == "h");
        }

        /// <summary>
        /// Updates the player's score.
        /// </summary>
        public void DoUpdates()
        {   
            // If game is over end game.
            if (!isPlaying)
            {
                return;
            }
            
            // Create variable to store last card value before changed.
            int lastValue = card.value;

            // Generate new card value.
            card.Draw();

            // Find out if guess was correct or not.
            bool valueIsHigher = (card.value > lastValue);

            if (!(valueIsHigher ^ guessIsHigher)) {
                
            }
            
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


