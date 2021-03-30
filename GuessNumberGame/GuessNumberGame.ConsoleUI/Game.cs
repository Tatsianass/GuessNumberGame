﻿using GuessNumberGame.ConsoleUI.Models;
using System;

namespace GuessNumberGame.ConsoleUI
{
    public class Game
    {
        private readonly GameConfigurationModel gameConfigurationModel;

        public Game(GameConfigurationModel gameConfigurationModel)
        {
            this.gameConfigurationModel = gameConfigurationModel;
        }

        public void Play()
        {
            int numberOfTry = 3;
            int wishNumber = 0;
            bool isUserWon = false;

            GetWishNumber();
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
                    DisplayHint(enteredTry, wishNumber);
                }
            }

            DisplayResult(isUserWon);
        }

        private int AskUserWishNumber()
        {
            ConsoleWriter.Write("Your try: ");
            return ConsoleReader.GetEnteredNumber();
        }

        private void DisplayResult(bool isUserWon)
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

        private void DisplayHint(int enteredValue, int wishNumber)
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

        private int GetWishNumber()
        {
            int wishNumber = 0;
            var isWishNumberValid = false;
            do
            {
                ConsoleWriter.Write("Please, enter wish number: ");
                wishNumber = ConsoleReader.GetEnteredNumber();
                isWishNumberValid = ValidateWishNumber(wishNumber);

                if (!isWishNumberValid)
                {
                    ConsoleWriter.WriteLine($"Please, enter number in range from {gameConfigurationModel.RangeNumberFrom} to {gameConfigurationModel.RangeNumberTo}");
                }

            } while (!isWishNumberValid);
            return wishNumber;
        }

        private bool ValidateWishNumber(int wishNumber)
        {
            return wishNumber >= gameConfigurationModel.RangeNumberFrom && wishNumber <= gameConfigurationModel.RangeNumberTo;
        }
    }
}
