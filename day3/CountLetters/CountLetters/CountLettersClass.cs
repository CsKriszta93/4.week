using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CountLetters
{
    public class CountLettersClass
    {
        public Dictionary<char, int> CountLetter(string input)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            char[] inputChar = input.ToCharArray();
            foreach (char letter in inputChar)
            {
                if (!dictionary.ContainsKey(letter))
                {
                    dictionary.Add(letter, 1);
                }
                else
                {
                    dictionary[letter]++;
                }
                
            }
            return dictionary;
        }

    }
}
