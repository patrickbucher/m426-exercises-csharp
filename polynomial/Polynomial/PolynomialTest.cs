using Xunit;

namespace Polynomial;

public class PolynomialTest
{
    int Polynomial(int x, int y)
    {
        int xToThePowerOfThree = 1;
        for (int i = 0; i < 3; i++)
        {
            xToThePowerOfThree *= x;
        }

        int yToThePowerOfFour = 1;
        for (int i = 0; i < 4; i++)
        {
            yToThePowerOfFour *= y;
        }

        return 8 * xToThePowerOfThree + 2 * yToThePowerOfFour;
    }

    [Fact]
    void TestPolynomial()
    {
        // Arrange
        int x = 2;
        int y = 3;
        int expected = 226; // 8x³ + 2y⁴

        // Act
        int actual = Polynomial(x, y);

        // Assert
        Assert.Equal(actual, expected);
    }
}