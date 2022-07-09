using Xunit;

namespace Playground.Tests
{
    public class RuleOfThreeTest
    {
        [Fact]
        public void TenForTwoIsFiveForOne()
        {
            // Arrange
            double total = 10.0;
            double amount = 2.0;
            double wantedTotal = 5.0;
            RuleOfThree rule = new RuleOfThree(total, amount);

            // Act
            double actualTotal = rule.CalculateFor(1);

            // Assert
            Assert.Equal(wantedTotal, actualTotal);
        }
    }
}
