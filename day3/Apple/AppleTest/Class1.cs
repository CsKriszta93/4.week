using System;
using NUnit.Framework;
using Apple;

namespace Apple.Test
{
    [TestFixture]
    public class AppleTest
    {
        [Test]
        public void GetApple()
        {
            string apple = "apple";
            var Appletest = new Apple();
            string output = Appletest.Printapple();
            Assert.AreEqual(apple, output);
        }
    }
}
