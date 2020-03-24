using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hangman_Game.Models
{
    public class WordGuessGame
    {
        public RoundCounter Counter { get; }
        public WordManager WordManager { get; }
        public char[] PossibleLetters { get; }
        public List<char> Guesses { get; private set; }
        public static string Word { get; set; }
        public char[] SecretWord { get; set; }
        public WordGuessGame()
        {
            this.Counter = new RoundCounter();
            this.WordManager = new WordManager();
            this.Guesses = new List<char>();
            this.PossibleLetters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        }
        public void ReadyWord()
        {
            Word = WordManager.ObtainRandomWord();
            SecretWord = WordManager.HideWord(Word);
        }

        public bool IsGameOver()
        {
            if (Counter.GuessesRemaining == 0 || Counter.LettersRevealed == Word.Count())
            {
                return true;
            }
            return false;
        }

        public void CompleteRound(int index)
        {
            Guesses.Add(PossibleLetters[index]);
            AppendSecretWord(index);
        }

        public bool DoesWordContainGuess(int index)
        {
            if (Word.Contains(PossibleLetters[index]))
            {
                return true;
            }
            return false;
        }

        public void AppendSecretWord(int index)
        {
            if (Word.Contains(PossibleLetters[index]))
            {
                for (int i = 0; i < SecretWord.Length; i++)
                {
                    if (Word[i] == PossibleLetters[index])
                    {
                        SecretWord[i] = PossibleLetters[index];
                        Counter.LettersRevealed++;
                    }
                }
            }
            else
            {
                Counter.GuessesRemaining--;
                return;
            }
        }

        public int TallyRoundScore()
        {
            int score = Counter.GuessesRemaining * 100;
            return score;
        }
    }
}
