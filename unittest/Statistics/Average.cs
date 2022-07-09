using System;
using System.Collections.Generic;

namespace Statistics
{
    public class Average
    {
        public double Mean(List<int> numbers)
        {
            int sum = 0;
            double mean = 0.0;

            if (numbers.Count == 0)
            {
                throw new ArgumentException("mean of empty list is undefined");
            }

            foreach (int number in numbers)
            {
                sum += number;
            }

            mean = (double)sum / numbers.Count;
            return mean;
        }

        public double Median(List<int> numbers)
        {
            numbers.Sort();
            int n = numbers.Count;
            if (n == 0)
            {
                throw new ArgumentException("Median not defined for empty list");
            }
            else if (n % 2 == 0)
            {
                int middleUpper = (int)(n / 2);
                int middleLower = middleUpper - 1;
                List<int> twoMiddleNumbers = new List<int>{
                    numbers[middleLower],
                    numbers[middleUpper]
                };
                return Mean(twoMiddleNumbers);
            }
            else if (n % 2 == 1)
            {
                int middle = (int)(n / 2);
                return (double)numbers[middle];
            }
            return -1;
        }
    }
}
