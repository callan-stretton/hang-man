using System;
using System.Text; // used for the StringBuilder

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
            displayWord(wordToGuess);
            //int playerTurnCount = 0;
            Console.WriteLine("Let's play Hangman! Guess the word.");
            //string hiddenWord = 
        }
        static public string displayWord(string word)
        {
            string updatedWord = word + " is working";
            string blankWord = "";
            StringBuilder sb = new StringBuilder();

            sb.Append("hello");

            sb.Insert("  ", 0);

            string str1 = sb.ToString();
            for (int i = 0; i < word.Length; i++)
            {
                blankWord + "_";
            }
            return initialBlankWord;
        }
    }
}


// Pseudocode:
// Set playerTurnCount to 7 (for number of lines that make up the hangman drawing)
// Identify the wordToGuess, push _ to new hiddenWord array by length of word
// Display the hiddenWord array with -- string.Join(" ", hiddenWord) -- it will add spaces to look like _ _ _ _
// Have a while loop so while game has not ended (conditions are: word solved OR playerTurnCount <= 0) do the following:
// Ask for a letter (currentLetterGuess)
// If wordToGuess contains currentLetterGuess
// Find out the index of that character in the wordAsArray array and replace the _ in the hiddenWord array at the same index
// Add this character to a guessedChars array
// If wordToGuess does not contain currentLetterGuess
// Add this character to a guessedChars array
// Deduct 1 from the playerTurnCount counter


// On each round print hiddenWord, attempts left 