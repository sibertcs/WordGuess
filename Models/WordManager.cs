using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Hangman_Game.Models
{
    public class WordManager
    {

        public List<string> Words { get; private set; }

        public WordManager()
        {
            this.Words = PopulateList();
        }

        public List<string> PopulateList()
        {
            List<string> words = new List<string>();

            string filePath = @"C:\Users\Student\workspace\_Projects\Hangman_Game\Text File\Words.txt";

            using (StreamReader sr = new StreamReader(filePath))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    words.Add(line);
                }
                return words;
            }
        }

        public string ObtainRandomWord()
        {
            var Random = new Random();
            int index = Random.Next(Words.Count);

            string word = Words[index];
            return word;
        }

        //used for testing purposes only!//
        //public string ObtainRandomWord()
        //{
        //    return "cactus";
        //}

        public char[] HideWord(string word)
        {
            char[] hiddenWord = new char[word.Length];

            for (int i = 0; i < word.Length; i++)
            {
                hiddenWord[i] = '_';
            }
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
