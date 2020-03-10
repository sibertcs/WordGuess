using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading;
using System.Threading.Tasks;

namespace Hangman_Game.Models
{
    public class HangManGameBoard
    {

        public Counter Counter { get; set; } = new Counter();

        public static WordManager WordManager { get; set; } = new WordManager();

        public char[] PossibleLetters { get; set; } = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        public List<char> Guesses { get; set; } = new List<char>();
        public static string Word { get; set; } 

        public char[] SecretWord { get; set; } 

        public void ReadyWord()
        {        
            Word = WordManager.ObtainRandomWord();
            SecretWord = WordManager.HideWord(Word);
        }

        public bool IsGameOver()
        {
            if(Counter.GuessesRemaining == 0 || Counter.LettersRevealed == Word.Count())
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

        public bool DoesContainLetter(int index)
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

        public int TallyGameScore()
        {
            int score = 0;
            score = Counter.GuessesRemaining * 100;
            return score;
        }
       

    }
}
