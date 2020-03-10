using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hangman_Game.Models
{
    public class WordManager
    {
        public char[] HiddenWord { get; set; }


        private List<string> Words = new List<string>() { "puzzle", "elephant", "turtle", "cabinet", "internet", "television", "cactus" };

        public string ObtainRandomWord()
        {
            var Random = new Random();
            int index = Random.Next(Words.Count);
            string word = Words[index];
            return word;
        }

        public char[] HideWord(string word)
        {
            char[] hiddenWord = new char[word.Length];

            for (int i = 0; i < word.Length; i++)
            {
                hiddenWord[i] = '_';
            }
            //List<char> secretWord = hiddenWord.ToList<char>();
            return hiddenWord;
        }

        public string AppendWord(string[] secretWord)
        {
            string appendedWord = "";
            for (int i = 0; i < secretWord.Length; i++)
            {
                appendedWord += secretWord[i];
            }
            return appendedWord;
        }
    }
}
