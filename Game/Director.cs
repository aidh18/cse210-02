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
        int totalScore = 300;
        Card card = new Card();
        bool guessIsHigher = false;

        // <summary>
        // Constructs a new instance of Director.
        // </summary>
        public Director()
        {
            card.Draw();
        }

        // <summary>
        // Starts the game by running the main game loop.
        // </summary>
        public void StartGame()
        {
            while (isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        // <summary>
        // Asks the user if they want to play again and their guess.
        // </summary>
        public void GetInputs()
        {   
            // Ask user to play again.
            Console.Write("\nPlay again? [y/n] ");

            // If the users says no end game.
            isPlaying = (Console.ReadLine() == "y");

            if (!isPlaying) {
                return;
            }

            // Print card name so that user can make a guess.
            Console.WriteLine($"The card is: {card.name}.");

            // GET guess.
            Console.Write("Higher or lower? [h/l] ");            
            guessIsHigher = (Console.ReadLine() == "h");
        }

        // <summary>
        // Updates the player's score.
        // </summary>
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

            // Use an xor to figure out player points. 
            int points = 0;

            if (valueIsHigher ^ guessIsHigher) {

                // Incorrect guess.
                points = -75;

            } else {
                
                // Correct guess.
                points = 100;
            }

            // Add points to total score.
            totalScore += points;
            
        }

        // <summary>
        // Displays the next card and the score.  
        // </summary>
        public void DoOutputs()
        {   
            // If game is over end game.
            if (!isPlaying)
            {
                return;
            }

            // Output to user.
            Console.WriteLine($"Next card was: {card.name}");
            Console.WriteLine($"Your score is: {totalScore}\n");

            // Check end game conditions.
            isPlaying = (totalScore > 0);
        }
    }
}


