using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    ///<summary>Class to test MyMath.Max()</summary>
    [TestFixture]
    public class Tests
    {
        [Test]
        public void PositiveNumbers()
        {
            List<int> nums = new List<int> {0, 1, 2, 3, 4};
            int maxNum = Operations.Max(nums);
            Assert.AreEqual(4, maxNum);
        }

        [Test]
        public void NegativeNumbers()
        {
            List<int> nums = new List<int> {-1, -2, -3, -4};
            int maxNum = Operations.Max(nums);
            Assert.AreEqual(-1, maxNum);
        }

        [Test]
        public void PositiveandNegativeNumbers()
        {
            List<int> nums = new List<int> {0, 1, 2, -3, -4};
            int maxNum = Operations.Max(nums);
            Assert.AreEqual(2, maxNum);
        }

        [Test]
        public void AlltheSame()
        {
            List<int> nums = new List<int> {5, 5, 5, 5, 5};
            int maxNum = Operations.Max(nums);
            Assert.AreEqual(5, maxNum);
        }

        [Test]
        public void EmptyList()
        {
            List<int> nums = new List<int> {};
            int maxNum = Operations.Max(nums);
            Assert.AreEqual(0, maxNum);
        }
    }
}