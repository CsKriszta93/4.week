using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Sum;

namespace SumTest
{
    [TestFixture]
    public class SumTest
    {
        [Test]
        public void PrintSumTest()
        {
         SumClass summ = new SumClass();
            var listie = new List<int> { 3, 3, 4, 5, 6, 6 };
            int output = 27;
            Assert.AreEqual(output, summ.Summy(listie));
        }

        [Test]
        public void PrintOneNumberTest()
        {
            SumClass summ = new SumClass();
            var listie = new List<int> {8};
            int output = 8;
            Assert.AreEqual(output, summ.Summy(listie));
        }
    }
}
