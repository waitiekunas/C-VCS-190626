using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int number = 5;
            Assert.AreEqual(3 + 2, number, "should have been 5");
        }
    }
}
