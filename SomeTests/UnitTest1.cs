using System;
using System.Linq;
using Xunit;

namespace SomeTests
{
    public class UnitTest1
    {
        [Fact(DisplayName = "Successful Test")]
        public void SuccessfulTest()
        {
            Assert.True(true, "some message!");
        }

        [Fact(DisplayName = "Skipped Test", Skip = "Just skip for a moment")]
        void Skipped()
        {
            Assert.True(false);
        }
    }
}
