using NUnit.Framework;

namespace Text.Tests
{
    ///<summary>Class to test Str.CamelCase()</summary>
    [TestFixture]
    public class Tests
    {
        [Test]
        public void easyTest()
        {
            string s = "twoWords";
            int wordCount = Str.CamelCase(s);
            Assert.AreEqual(2, wordCount);
        }

        [Test]
        public void oneWord()
        {
            string s = "two";
            int wordCount = Str.CamelCase(s);
            Assert.AreEqual(1, wordCount);
        }

        [Test]
        public void manyWords()
        {
            string s = "therAreSoManyWords";
            int wordCount = Str.CamelCase(s);
            Assert.AreEqual(5, wordCount);
        }

        [Test]
        public void emptyString()
        {
            string s = "";
            int wordCount = Str.CamelCase(s);
            Assert.AreEqual(0, wordCount);
        }
    }
}