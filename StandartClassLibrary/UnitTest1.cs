using SimpleApp;
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
            var a = Program.Sum(2, 2);
            Assert.Equal(4, a);
        }

        [Fact(DisplayName = "Sum of Tuple")]
        void SumTuple()
        {
            Assert.Equal(4, Program.Sum((2, 2)));
        }

        [Fact(DisplayName = "Failed test", Skip = "The Skipped test")]
        public void XTestFail()
        {
#if NET452
            Assert.True(false, "!!!! net452 !!!!");
#else
            Assert.True(false, "!!!! netcoreapp !!!!");
#endif
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
