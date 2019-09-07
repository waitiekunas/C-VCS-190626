using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProject2
{
    [TestClass]
    public class BasicTest
    {
        [TestMethod]
        public void CheckSum()
        {
            int sum = 4;

            Assert.AreEqual(2 + 2, sum, "sum is correct");

        }
    }
}
