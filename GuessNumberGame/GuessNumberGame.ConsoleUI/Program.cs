namespace GuessNumberGame.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleWriter.WriteLine("Welcome to Guess Number Game!");
            do
            {
                Game game = new Game();
                game.Play();
            } while (true);
        }
    }
}
