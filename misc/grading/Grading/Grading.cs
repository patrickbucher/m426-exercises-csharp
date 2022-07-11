using System;
using System.Collections.Generic;

namespace Grading
{
    public class Grading
    {

        public static double MIN_GRADE = 1.0;
        public static double MAX_GRADE = 6.0;

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static double Average(IList<double> grades)
        {
            var sum = 0.0;
            foreach (var grade in grades)
            {
                sum += grade;
            }
            return sum / (double)grades.Count;
        }

        public static double RoundTo(double granularity, double value)
        {
            var upscaled = (1 / granularity) * value;
            var rounded = Math.Round(upscaled, MidpointRounding.AwayFromZero);
            var downscaled = rounded * granularity;
            return downscaled;
        }


        /// computation:
        /// average = (sum(grades) + x) / (n_grades + 1)  | * (n_grades + 1)
        /// average * (n_grades + 1) = sum(grades) + x    | - sum(grades)
        /// average * (n_grades + 1) - sum(grades) = x
        public static double GradeNeededForAverage(IList<double> grades, double goal)
        {
            var sum = 0.0;
            foreach (var grade in grades)
            {
                sum += grade;
            }
            var x = goal * (grades.Count + 1) - sum;
            if (x > MAX_GRADE) {
                throw new ArgumentOutOfRangeException("grades", "The goal is unreachable high.");
            }
            if (x < MIN_GRADE) {
                throw new ArgumentOutOfRangeException("grades", "The goal is unreachable low.");
            }
            return x;
        }
    }
}
