namespace GuessNumberGame.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Game game = new Game();
                game.Play();
            } while (true);
        }
    }
}
