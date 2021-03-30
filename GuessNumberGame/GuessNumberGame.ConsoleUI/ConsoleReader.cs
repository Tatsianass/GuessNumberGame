using System;

namespace GuessNumberGame.ConsoleUI
{
    public class ConsoleReader
    {
        public static int GetEnteredNumber()
        {
            string tryValue = Console.ReadLine();
            bool isParcedSuccessfully = int.TryParse(tryValue, out int parcedValue);
            if (!isParcedSuccessfully)
            {
                ConsoleWriter.WriteLine("Error. Please, enter only numbers: ");
                GetEnteredNumber();
            }
            return parcedValue;
        }
    }
}
