using cse210_02.Game;


namespace cse210_02
{
    /// <summary>
    /// The program's entry point.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Starts the program using the given arguments.
        /// </summary>
        /// <param name="args">The given arguments.</param>
        static void Main(string[] args)
        {
            Director director = new Director();
            director.StartGame();
        }
    }
}