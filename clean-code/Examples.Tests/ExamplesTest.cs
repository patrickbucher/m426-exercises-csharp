using System;
using System.Collections.Generic;
using Xunit;

namespace Examples.Tests
{
    public class ExamplesTest
    {
        [Fact]
        public void TestMedianOfOddNumberOfElements()
        {
            var numbers = new List<double>() { 1.0, 2.0, 3.0, 4.0, 5.0 };
            Assert.Equal(3.0, Calculator.Median(numbers));
        }

        [Fact]
        public void TestMedianOfEvenNumberOfElements()
        {
            var numbers = new List<double>() { 1.0, 2.0, 3.0, 4.0 };
            Assert.Equal(2.5, Calculator.Median(numbers));
        }
        [Fact]
        public void TestHackyMedianOfOddNumberOfElements()
        {
            var numbers = new List<double>() { 1.0, 2.0, 3.0, 4.0, 5.0 };
            Assert.Equal(3.0, Calculator.HackyMedian(numbers));
        }

        [Fact]
        public void TestHackyMedianOfEvenNumberOfElements()
        {
            var numbers = new List<double>() { 1.0, 2.0, 3.0, 4.0 };
            Assert.Equal(2.5, Calculator.HackyMedian(numbers));
        }
        [Fact]
        public void TestWhackyMedianOfOddNumberOfElements()
        {
            var numbers = new List<double>() { 1.0, 2.0, 3.0, 4.0, 5.0 };
            Assert.Equal(3.0, Calculator.WhackyMedian(numbers));
        }

        [Fact]
        public void TestWhackyMedianOfOddNumberOfFewerElements()
        {
            var numbers = new List<double>() { 1.0, 2.0, 3.0 };
            Assert.Equal(2.0, Calculator.WhackyMedian(numbers));
        }

        [Fact]
        public void TestWhackyMedianOfEvenNumberOfElements()
        {
            var numbers = new List<double>() { 1.0, 2.0, 3.0, 4.0 };
            Assert.Equal(2.5, Calculator.WhackyMedian(numbers));
        }

        [Fact]
        public void TestTwiceOfPositiveNumber()
        {
            Assert.Equal(4, Calculator.Twice(2));
        }

        [Fact]
        public void TestTwiceOfNegativeNumber()
        {
            Assert.Equal(-4, Calculator.Twice(-2));
        }
    }
}
