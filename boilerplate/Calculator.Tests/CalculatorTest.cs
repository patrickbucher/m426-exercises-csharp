using System;
using Xunit;
using Calculator;

namespace Calculator.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void FivePlusThreeIsEight()
        {
            Assert.Equal(8, Calculator.Add(3, 5));
        }
    }
}
