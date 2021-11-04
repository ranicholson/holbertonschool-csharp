using NUnit.Framework;

namespace InventoryManagement.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BaseClass_Instance()
        {
            BaseClass baseTestClass = new BaseClass();
            Assert.AreEqual(baseTestClass.date_created, baseTestClass.date_updated);
        }
    }
}