using GuessNumberGame.ConsoleUI.Models;

namespace GuessNumberGame.ConsoleUI.Validators
{
    public class WishNumberValidator
    {
        private readonly GameConfigurationModel gameConfigurationModel;
        
        public WishNumberValidator(GameConfigurationModel gameConfigurationModel) 
        {
            this.gameConfigurationModel = gameConfigurationModel;
        }

        public bool IsNumberInRange(int number)
        {
            bool isNumberInRange = false;
            if (number >= gameConfigurationModel.RangeNumberFrom && number <= gameConfigurationModel.RangeNumberTo)
            {
                isNumberInRange = true;
            }

            return isNumberInRange;
        }
    }
}
