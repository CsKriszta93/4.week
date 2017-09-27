using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anagram;

namespace AnagramTest
{
    [TestFixture]
    public class AnagramTestClass
    {
        [Test]
        public void AnagramTesterTest()
        {
            AnagramClass anagram = new AnagramClass();
            bool output = true;
            string input1 = "dog";
            string input2 = "god";
            Assert.AreEqual(output, anagram.AnagramTester(input1, input2));
        }
    }
}
