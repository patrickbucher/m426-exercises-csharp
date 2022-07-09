using System;

namespace Playground
{
    public class RuleOfThree
    {
        private double totalPrice;
        private double amount;

        public RuleOfThree(double totalPrice, double amount)
        {
            this.totalPrice = totalPrice;
            this.amount = amount;
        }
        public double CalculateFor(double wantedAmount)
        {
            double singleUnitPrice = this.totalPrice / this.amount;
            return singleUnitPrice * wantedAmount;
        }

    }
}
