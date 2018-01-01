using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleApp;

namespace Test1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var t = Program.Sum(4, 6);
            Assert.AreEqual(10, t);
        }
    }
}
