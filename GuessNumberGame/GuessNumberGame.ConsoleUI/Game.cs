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

            Console.WriteLine("Please, enter wish number");
            wishNumber = GetEnteredNumber();

            Console.Clear();

            int enteredTry = 0;
            Console.WriteLine("Guess the number:");

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
            Console.Write("Your try:");
            return GetEnteredNumber();
        }

        private static int GetEnteredNumber()
        {
            string tryValue = Console.ReadLine();
            bool isParcedSuccessfully = int.TryParse(tryValue, out int parcedValue);
            if (!isParcedSuccessfully)
            {
                Console.WriteLine("Error. Please, enter only numbers:");
                GetEnteredNumber();
            }
            return parcedValue;
        }

        private static void DisplayResult(bool isUserWon)
        {
            if (isUserWon)
            {
                Console.WriteLine("Well Done!");
            }
            else
            {
                Console.WriteLine("Game over!");
            }
        }

        private static void DisplayHint(int enteredValue)
        {
            if (enteredValue > wishNumber)
            {
                Console.WriteLine($"Hint: Wish number is less than {enteredValue}");
            }
            else
            {
                Console.WriteLine($"Hint: Wish number is bigger than {enteredValue}");
            }
        }
    }
}
