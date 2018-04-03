using System;
using System.Text; // used for the StringBuilder
using System.Linq;

namespace hangman
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string wordToGuess = "FROG";
            var wordAsArray = wordToGuess.ToCharArray().Select(c => c.ToString()).ToArray();
            Console.WriteLine("What's your letter?");
            string firstGuess = Console.ReadLine().ToUpper();
            //string firstGuess = "o";
            int myIndex = Array.IndexOf(wordAsArray, firstGuess);
            if (myIndex == -1)
            {
                Console.WriteLine("Run wrong letter function");
            }
            else{
                Console.WriteLine("Run correct letter function");
            }
            Console.WriteLine("The first occurrence of " + firstGuess + " is at index " + myIndex);
            Console.WriteLine(string.Join(",", wordAsArray)); // prints each item of array to view in console (by joining with ,)
            string[] workingArray = new string[0];
            initialiseBlankWord(wordToGuess);
            //int playerTurnCount = 0;
            //string hiddenWord = 
            // myArray.SetValue( "fox", 3 );
        }
        static public string initialiseBlankWord(string word)
        {
            string fullBlankWord = new String('_', word.Length); // initialises a new string with character by word.Length amount of times
            char[] fullBlankWordArr = fullBlankWord.ToCharArray();
            Console.WriteLine(fullBlankWord);
            Console.WriteLine(string.Join(" ", fullBlankWordArr));
            return fullBlankWord;
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
// Things to look out for: to lower case



//Alternate long version of making blank word: 
//StringBuilder buildingBlankWord = new StringBuilder(); // blank starting point as no string already in parenthesis

//for (int i = 0; i<word.Length; i++)
//{
//buildingBlankWord.Append("_"); // adds a _ to the end of the StringBuilder
//}
//string fullBlankWord = buildingBlankWord.ToString(); // converting back down to simple string
