using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hangman_Game.Models
{
    public class RoundCounter
    {
        public List<char> IncorrectGuesses { get; private set; }

        public List<char> CorrectGuessses { get; private set; }

        public int LettersRevealed { get; set; }

        public int GuessesRemaining { get; set; }

        public RoundCounter()
        {
            this.IncorrectGuesses = new List<char>() { };
            this.CorrectGuessses = new List<char>() { };
            this.GuessesRemaining = 12;
            this.LettersRevealed = 0;
        }
    }
}
