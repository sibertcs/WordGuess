using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hangman_Game.Models
{
    public class Counter
    {
        public List<char> IncorrectGuesses { get; private set; }

        public List<char> CorrectGuessses { get; private set; }

        public int NumberOfIncorrectGuesses { get; set; }

        public int LettersRevealed { get; set; }

        public int GuessesRemaining { get; set; }

        public int WordsCorrect { get; set; }

        public int WordsAttempted { get; set; }

        public int Score { get; set; }

        public Counter()
        {
            this.IncorrectGuesses = new List<char>() { };
            this.CorrectGuessses = new List<char>() { };
            this.GuessesRemaining = 10;
            this.NumberOfIncorrectGuesses = 0;
            this.LettersRevealed = 0;
        }

        public string UpdateIncorrectGuesses()
        {
            string guesses = "";
            foreach (char letter in IncorrectGuesses)
            {
                guesses += ($"{letter} ");
            }
            return guesses;
        }
    }
}
