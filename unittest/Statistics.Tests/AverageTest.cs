using System;
using System.Collections.Generic;
using Xunit;

namespace Statistics.Tests
{
    public class AverageTest
    {
        [Fact]
        public void TestMeanOfFourNumbers()
        {
            List<int> numbers = new List<int> { 1, 4, 1, 3 };
            double expected = 2.25;
            Average average = new Average();

            double actual = average.Mean(numbers);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMeanOfFiveNumbers()
        {
            List<int> numbers = new List<int> { 10, 15, 5, 25, 50 };
            double expected = 21;
            Average average = new Average();

            double actual = average.Mean(numbers);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMeanOfNoNumbersIsUndefined()
        {
            List<int> numbers = new List<int> { };
            Average average = new Average();

            Assert.Throws<ArgumentException>(() => average.Mean(numbers));
        }

        [Fact]
        public void TestMedianForOddNumberOfElements()
        {
            List<int> numbers = new List<int> { 1, 4, 2 };
            double expected = 2.0;
            Average average = new Average();

            double actual = average.Median(numbers);

            Assert.Equal(actual, expected);
        }

        [Fact]
        public void TestMedianForEvenNumberOfElements()
        {
            List<int> numbers = new List<int> { 1, 2, 5, 4 };
            double expected = 3.0;
            Average average = new Average();

            double actual = average.Median(numbers);

            Assert.Equal(actual, expected);
        }
        [Fact]
        public void TestMedianForNoElements()
        {
            List<int> numbers = new List<int> { };
            Average average = new Average();

            Assert.Throws<ArgumentException>(() => average.Median(numbers));
        }
    }
}
