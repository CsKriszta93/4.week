using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    public class AnagramClass
    {
        public bool AnagramTester(string input1, string input2)
        {
            char[] char1 = input1.ToCharArray();
            char[] char2 = input2.ToCharArray();
            Array.Sort(char1);
            Array.Sort(char2);

            if (char1.Length != char2.Length)
            {
                return false;
            }
            for (int i = 0; i < char1.Length; i++)
            {
                if (char1[i] != char2[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
