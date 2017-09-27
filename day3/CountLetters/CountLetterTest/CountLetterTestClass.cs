using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CountLetters;


namespace CountLetterTest
{
    [TestFixture]
    public class CountLetterTestClass
    {
        [Test]
        public void CountLetterTest()
        {
            CountLettersClass lettertest = new CountLettersClass();
            string input = "blablabbla";
            Dictionary<char, int> output = new Dictionary<char, int>();
            output.Add('b', 4);
            output.Add('l', 3);
            output.Add('a', 3);

            Assert.AreEqual(output, lettertest.CountLetter(input));

        }
    }
}
