using NUnit.Framework;

namespace MyMath.Tests
{
    ///<summary>Class containing nunit tests</summary>
    [TestFixture]
    public class Tests
    {
        [Test]
        public void addPositiveNumbers()
        {
            int a = 5;
            int b = 20;
            int sum = MyMath.Operations.Add(a, b);
            Assert.AreEqual(a + b, sum);
        }
        [Test]
        public void addMixedSigns()
        {
            int a = 5;
            int b = -20;
            int sum = MyMath.Operations.Add(a, b);
            Assert.AreEqual(a + b, sum);
        }
        [Test]
        public void addNegativeNumbers()
        {
            int a = -5;
            int b = -20;
            int sum = MyMath.Operations.Add(a, b);
            Assert.AreEqual(a + b, sum);
        }
        [Test]
        public void addZero()
        {
            int a = 0;
            int b = 0;
            int sum = MyMath.Operations.Add(a, b);
            Assert.AreEqual(a + b, sum);
        }
    }
}