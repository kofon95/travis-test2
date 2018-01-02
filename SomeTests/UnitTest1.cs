using System;
using Xunit;

namespace SomeTests
{
    public class UnitTest1
    {
        [Fact(DisplayName = "Successful Test")]
        public void SuccessfulTest()
        {
            var a = SimpleApp.Program.Sum((3, 5));
            Assert.True(a == 8, "some message!");
        }

        [Fact(DisplayName = "Skipped Test", Skip = "Just skip for a moment")]
        void Skipped()
        {
            Assert.True(false);
        }
    }
}
