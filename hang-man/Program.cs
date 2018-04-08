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
            string[] wordAsArray = wordToGuess.ToCharArray().Select(c => c.ToString()).ToArray();
            string[] workingWord = InitialiseBlankWord(wordToGuess);
            Console.WriteLine(string.Join(" ", workingWord));
            int playerTurnCount = 7;
            bool gameOver = false;

            //while (gameOver == false) {
            //    IsItGameOver(playerTurnCount);
            //}
            Console.WriteLine("gameOver = " + gameOver);
            IsItGameOver(ref gameOver);
            Console.WriteLine("Running IsItGameOver");
            Console.WriteLine("gameOver = " + gameOver);

            Console.WriteLine("What's your letter?");
            string firstGuess = Console.ReadLine().ToUpper();
            int myIndex = Array.IndexOf(wordAsArray, firstGuess);
            if (myIndex == -1)
            {
                Console.WriteLine("Run wrong letter function");
                playerTurnCount = playerTurnCount - 1;
                Console.WriteLine(playerTurnCount + " Turns left");
            }
            else
            {
                Console.WriteLine("Run correct letter function");
                Console.WriteLine("Yes " + firstGuess + " is a letter!");
                Console.WriteLine("The first occurrence of " + firstGuess + " is at index " + myIndex);
                workingWord.SetValue(firstGuess, myIndex);
                Console.WriteLine(string.Join(" ", workingWord));
            }
        }
        public static string[] InitialiseBlankWord(string word)
        {
            string fullBlankWord = new String('_', word.Length); // initialises a new string with character by word.Length amount of times
            string[] fullBlankWordArr = fullBlankWord.ToCharArray().Select(c => c.ToString()).ToArray();
            return fullBlankWordArr;
        }
        public static bool IsItGameOver (ref bool gameOver)
        {
            if (3 >= 0)
            {
                return gameOver = true;
            }
            else
            {
                return gameOver = false;
            }
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
