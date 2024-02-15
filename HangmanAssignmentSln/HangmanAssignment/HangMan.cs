using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanAssignment
{
    public class HangMan
    {
        private string[] words = { "cherry", "forest", "horse", "rose", "winter", "navy", "apple", "honey", "blue", "yellow" };

        private int maxGuesses = 10;

        private string currentWord;

        private List<char> guessedLetters;

        public HangMan()
        {
            Random random = new Random();
            int index = random.Next(words.Length);
            currentWord = words[index];

            guessedLetters = new List<char>();
        }

        public string GetWord()
        {
            string word = "";
            foreach (char c in currentWord)
            {
                if (guessedLetters.Contains(c))
                {
                    word += c + "";
                }
                else
                {
                    word += "_";
                }
            }
            return word;
        }
        public int GetGuesses()
        {
            return maxGuesses - guessedLetters.Count;
        }

        public bool isGameOver()
        {
            return GetGuesses() == 0 || GetWord().Replace("", "") == currentWord;
        }

        public bool IsWin()
        {
            return GetWord().Replace("", "") == currentWord;
        }

        public bool GuessedLetter(char letter)
        {
            letter = char.ToLower(letter);

            if (letter < 'a' || letter > 'z')
            {
                return false;
            }

            if (guessedLetters.Contains(letter))
            {
                return false;
            }
            guessedLetters.Add(letter);
            return currentWord.Contains(letter);

        }

        public void RestGame()
        {
            guessedLetters.Clear();
            Random random = new Random();
            int index = random.Next(words.Length);
            currentWord = words[index];
        }

        internal bool GuessedLetter(object guess)
        {
            throw new NotImplementedException();
        }
    }
}








       
    

