using Xunit;

namespace ShoppingCart.Tests;

public class CartItemTest
{
    [Fact]
    public void TestToString()
    {
        // Arrange
        CartItem eggs = new CartItem("eggs", 7);
        string expected = "7 x eggs";

        // Act
        string actual = eggs.ToString();

        // Assert
        Assert.Equal(actual, expected);
    }
}