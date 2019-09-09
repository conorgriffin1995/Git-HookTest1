using System;
using library;
using Xunit;

namespace test_library
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(42, new Thing().Get(19, 23));
        }
    }
}
