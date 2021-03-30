using System;

namespace GuessNumberGame.ConsoleUI
{
    public class ConsoleWriter
    {
        public static void WriteLine(string message)
        {
            Console.WriteLine($"[{DateTime.Now.ToShortTimeString()}] {message}");
        }

        public static void Write(string message)
        {
            Console.Write($"[{DateTime.Now.ToShortTimeString()}] {message}");
        }
    }
}
