using NUnit.Framework;
using System;

///<summary>Basic test file</summary>
namespace InventoryManagement.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void baseClassInstance()
        {
            Assert.AreEqual(0, 0);
        }
    }
}