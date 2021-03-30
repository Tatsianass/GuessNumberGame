using GuessNumberGame.ConsoleUI.Models;

namespace GuessNumberGame.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleWriter.WriteLine("Welcome to Guess Number Game!");
            do
            {
                GameConfigurator gameConfigurator = new GameConfigurator();
                GameConfigurationModel gameConfigurationModel = gameConfigurator.Configure();

                Game game = new Game(gameConfigurationModel);
                game.Play();
            } while (true);
        }
    }
}
