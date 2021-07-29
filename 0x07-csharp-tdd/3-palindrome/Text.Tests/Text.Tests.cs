using NUnit.Framework;
using System.Collections.Generic;

namespace Text.Tests
{
    ///<summary>Class to test Text.IsPalindrome()</summary>
    [TestFixture]
    public class Tests
    {
        [Test]
        public void easyTest()
        {
            string s = "tattarrattat";
            bool palindromeTest = Str.IsPalindrome(s);
            Assert.AreEqual(true, palindromeTest);
        }
        [Test]
        public void SpacesTest()
        {
            string s = " t a t t a r r a t t a t ";
            bool palindromeTest = Str.IsPalindrome(s);
            Assert.AreEqual(true, palindromeTest);
        }

        [Test]
        public void PunctionTest()
        {
            string s = "t?a.t,t'a;rrattat";
            bool palindromeTest = Str.IsPalindrome(s);
            Assert.AreEqual(true, palindromeTest);
        }

        [Test]
        public void spacesandPuncTest()
        {
            string s = ",t .at t'a' rr' 'at't 'a t.,";
            bool palindromeTest = Str.IsPalindrome(s);
            Assert.AreEqual(true, palindromeTest);
        }
        [Test]
        public void emptyTest()
        {
            string s = "";
            bool palindromeTest = Str.IsPalindrome(s);
            Assert.AreEqual(true, palindromeTest);
        }

        [Test]
        public void betterFailTest()
        {
            string s = "NOT A PALINDROME";
            bool palindromeTest = Str.IsPalindrome(s);
            Assert.AreEqual(false, palindromeTest);
        }

        [Test]
        public void caseTest()
        {
            string s = "taTtaRraTtAt";
            bool palindromeTest = Str.IsPalindrome(s);
            Assert.AreEqual(true, palindromeTest);
        }
    }
}