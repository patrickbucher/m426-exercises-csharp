using System;
using System.Collections.Generic;
using Xunit;

namespace Grading.Tests
{
    public class GradingTest
    {
        [Fact]
        public void TestAdd()
        {
            Assert.Equal(7, Grading.Add(3, 4));
        }

        [Fact]
        public void TestAverage()
        {
            var grades = new List<double>();
            grades.Add(6.0);
            grades.Add(5.0);

            var average = Grading.Average(grades);

            Assert.Equal(5.5, average);
        }

        [Fact]
        public void TestRoundTo()
        {
            var number = 5.25;

            var rounded = Grading.RoundTo(0.5, number);

            Assert.Equal(5.5, rounded);
        }

        [Fact]
        public void TestGradeNeededForAverage()
        {
            var grades = new List<double>();
            grades.Add(4.5);
            grades.Add(5.0);
            grades.Add(4.0);

            var gradeNeeded = Grading.GradeNeededForAverage(grades, 4.75);

            // (4.5+5.0+4.0+5.5)/4 = 4.75
            Assert.Equal(5.5, gradeNeeded);
        }

        [Fact]
        public void TestGradeNeededForAverageTooHigh()
        {
            var grades = new List<double>();
            grades.Add(4.5);
            grades.Add(5.0);
            grades.Add(4.0);

            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => Grading.GradeNeededForAverage(grades, 6.0));

            Assert.Equal(ex.Message, "The goal is unreachable high. (Parameter 'grades')");
        }

        [Fact]
        public void TestGradeNeededForAverageTooLow()
        {
            var grades = new List<double>();
            grades.Add(4.5);
            grades.Add(5.0);
            grades.Add(4.0);

            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => Grading.GradeNeededForAverage(grades, 1.0));

            Assert.Equal(ex.Message, "The goal is unreachable low. (Parameter 'grades')");
        }
    }
}
