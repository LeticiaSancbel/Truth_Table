using System;
using Truth_Table;
using Xunit;

namespace TestTruth_Table
{
    public class UnitTest1
    {
        [Fact]
        public void TestPositivo()
        {
            Class_operator service = new Class_operator();

            int character = service.result("a || b && c || d");
            Assert.Equal(2, character);
        }

        [Fact]
        public void TestNegativo()
        {
            Class_operator service = new Class_operator();

            int character = service.result("a || b && c || d");
            Assert.Equal(3, character);
        }
    }
}
