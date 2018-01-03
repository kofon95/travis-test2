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

#if NET452
        [Fact(DisplayName = "Skipped Test", Skip = "Just skip for NET452")]
#else
        [Fact(DisplayName = "Skipped Test", Skip = "Just skip for [other]")]
#endif
        void Skipped()
        {
            Assert.True(false);
        }
    }
}
