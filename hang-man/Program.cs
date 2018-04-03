using System;

namespace hangman
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string wordToGuess = "frog";
            char[] wordAsArray = wordToGuess.ToCharArray();
            Console.WriteLine(string.Join(",", wordAsArray)); // prints each item of array to view in console (by joining with ,)
            string[] workingArray = new string[0];
            //string displayWord = "";
            //int playerTurnCount = 0;
            Console.WriteLine("Let's play Hangman! Guess the word.");
        }
    }
}
