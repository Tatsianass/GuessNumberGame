using System;

namespace GuessNumberGame.ConsoleUI
{
    public class Game
    {
        private static readonly int numberOfTry = 3;
        private static int wishNumber = 0;

        public void Play()
        {
            bool isUserWon = false;

            ConsoleWriter.WriteLine("Please, enter wish number: ");
            wishNumber = GetEnteredNumber();

            Console.Clear();

            int enteredTry = 0;
            ConsoleWriter.WriteLine("Guess the number: ");

            for (int i = 0; i < numberOfTry; i++)
            {
                enteredTry = AskUserWishNumber();

                if (wishNumber == enteredTry)
                {
                    isUserWon = true;
                    break;
                }
                else
                {
                    DisplayHint(enteredTry);
                }
            }

            DisplayResult(isUserWon);
        }

        private static int AskUserWishNumber()
        {
            ConsoleWriter.Write("Your try: ");
            return GetEnteredNumber();
        }

        private static int GetEnteredNumber()
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

        private static void DisplayResult(bool isUserWon)
        {
            if (isUserWon)
            {
                ConsoleWriter.WriteLine("Well Done!");
            }
            else
            {
                ConsoleWriter.WriteLine("Game over!");
            }
        }

        private static void DisplayHint(int enteredValue)
        {
            if (enteredValue > wishNumber)
            {
                ConsoleWriter.WriteLine($"Hint: Wish number is less than {enteredValue}");
            }
            else
            {
                ConsoleWriter.WriteLine($"Hint: Wish number is bigger than {enteredValue}");
            }
        }
    }
}
