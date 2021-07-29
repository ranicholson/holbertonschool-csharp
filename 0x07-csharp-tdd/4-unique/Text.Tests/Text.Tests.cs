using NUnit.Framework;
using System.Collections.Generic;

namespace Text.Tests
{
    ///<summary>Class to test Str.UniqueChar()</summary>
    [TestFixture]
    public class Tests
    {
        [Test]
        public void easyString()
        {
            string s = "eeaasy";
            int indexResult = Str.UniqueChar(s);
            Assert.AreEqual(4, indexResult);
        }

        [Test]
        public void noUnique()
        {
            string s = "eeaassyy";
            int indexResult = Str.UniqueChar(s);
            Assert.AreEqual(-1, indexResult);
        }

        [Test]
        public void firstUnique()
        {
            string s = "eaasy";
            int indexResult = Str.UniqueChar(s);
            Assert.AreEqual(0, indexResult);
        }

        [Test]
        public void LastUnique()
        {
            string s = "eeaassy";
            int indexResult = Str.UniqueChar(s);
            Assert.AreEqual(6, indexResult);
        }

        [Test]
        public void emptyString()
        {
            string s = "";
            int indexResult = Str.UniqueChar(s);
            Assert.AreEqual(-1, indexResult);
        }
    }
}