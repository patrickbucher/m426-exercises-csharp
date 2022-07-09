using System;

namespace Calculator
{
    public class Calculator
    {
        public int Add(int summandA, int summandB)
        {
            return summandA + summandB;
        }

        public int Subtract(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }

        public int Multiply(int productA, int productB)
        {
            return productA * productB;
        }

        public double Divide(int dividend, int divisor)
        {
            if (divisor == 0)
            {
                throw new ArgumentException("division by zero is undefined");
            }
            return dividend / divisor;
        }
    }
}
