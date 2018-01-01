using System;
using System.Linq;
using Xunit;

namespace UnitTestProject1
{
    public class UnitTest1
    {
        [Fact(DisplayName = "Successful test")]
        public void XTestMethod1()
        {
            Assert.True(true);
        }

        [Fact(DisplayName = "Failed test")]
        public void XTestFail()
        {
            Assert.True(false);
        }

        //[Theory(DisplayName = "DynamicTest")]
        //[InlineData(true)]
        //[InlineData(false)]
        //public void DynamicTest(bool success)
        //{
        //    Assert.True(success);
        //}
    }
}
