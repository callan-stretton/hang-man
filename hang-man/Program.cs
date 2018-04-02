using System;

namespace hangman
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string wordToGuess = "frog";
            var wordAsArray = wordToGuess.Split('');
            string[] workingArray = new string[0];
            string displayWord = "";
            int playerTurnCount = 0;
            Console.WriteLine("Let's play Hangman! Guess the word.");
        }
    }
}
