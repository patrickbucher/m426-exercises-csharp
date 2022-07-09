using System;
using System.Collections.Generic;

namespace Examples
{
    public class Calculator
    {
        public static void Main(string[] args)
        {
            Console.WriteLine((5 / 2) + 0.5); // 2.5
            Console.WriteLine((3 / 2) + 0.5); // 1.5
            Console.WriteLine(Convert.ToInt32((5 / 2) + 0.5)); // 2.0 (ok)
            Console.WriteLine(Convert.ToInt32((3 / 2) + 0.5)); // 2.0 (WTF!?)
            // see https://stackoverflow.com/q/11431793/6763074
        }

        public static double Median(List<double> numbers)
        {
            numbers.Sort();
            int n = numbers.Count;
            if (n == 0)
                throw new ArgumentException();
            if (n % 2 == 1)
                return numbers[n / 2];
            else
                return (numbers[n / 2 - 1] + numbers[n / 2]) / 2.0;
        }
        public static double HackyMedian(List<double> numbers)
        {
            numbers.Sort();
            int n = numbers.Count;
            if (n == 0)
                throw new ArgumentException();
            if ((n & 1) == 1)
                return numbers[n / 2];
            else
                return (numbers[n / 2 - 1] + numbers[n / 2]) / 2.0;
        }

        public static double WhackyMedian(List<double> numbers)
        {
            numbers.Sort();
            int n = numbers.Count;
            if (n == 0)
                throw new ArgumentException();
            if (n % 2 == 1)
                return numbers[Convert.ToInt32((n / 2) + 0.5)];
            else
                return (numbers[n / 2 - 1] + numbers[n / 2]) / 2.0;
        }

        public static int Twice(int x)
        {
            return x << 1;
        }
    }
}
