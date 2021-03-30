using GuessNumberGame.ConsoleUI.Models;

namespace GuessNumberGame.ConsoleUI
{
    public class GameConfigurator
    {
        public GameConfigurationModel Configure()
        {
            ConsoleWriter.WriteLine("Please, enter number range");
            
            ConsoleWriter.Write("From: ");
            int rangeNumberFrom = ConsoleReader.GetEnteredNumber();
            
            ConsoleWriter.Write("To: ");
            int rangeNumberTo = ConsoleReader.GetEnteredNumber();

            GameConfigurationModel gameConfigurationModel = new GameConfigurationModel
            {
                RangeNumberFrom = rangeNumberFrom,
                RangeNumberTo = rangeNumberTo
            };

            return gameConfigurationModel;
        }
    }
}
