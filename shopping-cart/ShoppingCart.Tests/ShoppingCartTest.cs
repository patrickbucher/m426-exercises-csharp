using System;
using System.Collections.Generic;
using Xunit;

namespace ShoppingCart.Tests;

public class ShoppingCartTest
{
    [Fact]
    public void TestEmptyCartHasNoProducts()
    {
        // Arrange
        ShoppingCart cart = new ShoppingCart();

        // Act
        List<string> actual = cart.GetProducts();

        // Assert
        Assert.Equal(actual.Count, 0);
    }

    [Fact]
    public void TestMissingProductHasNoAmount()
    {
        // Arrange
        ShoppingCart cart = new();

        // Act/Assert
        Assert.Throws<ArgumentException>(() =>
        {
            cart.GetAmountFor("milk");
        });
    }

    [Fact]
    public void TestAddedProductAppearsInCart()
    {
        // Arrange
        ShoppingCart cart = new();
        cart.AddItem("bananas", 3);

        // Act
        List<string> products = cart.GetProducts();

        // Assert
        Assert.Equal(products[0], "bananas");
    }

    [Fact]
    public void TestAddedProductHasCorrectAmount()
    {
        // Arrange
        ShoppingCart cart = new();
        cart.AddItem("potatoes", 17);
        int expected = 17;

        // Act
        int actual = cart.GetAmountFor("potatoes");

        // Assert
        Assert.Equal(actual, expected);
    }

    [Fact]
    public void TestAddSameProductTwiceAccumulatesAmount()
    {
        // Arrange
        ShoppingCart cart = new();
        cart.AddItem("eggs", 3);
        cart.AddItem("eggs", 6);
        int expected = 9;

        // Act
        int actual = cart.GetAmountFor("eggs");

        // Assert
        Assert.Equal(actual, expected);
    }

    [Fact]
    public void TestAddTwoProductsBothAppearInList()
    {
        // Arrange
        ShoppingCart cart = new();
        cart.AddItem("milk", 3);
        cart.AddItem("eggs", 7);

        // Act
        List<string> products = cart.GetProducts();

        // Assert
        Assert.True(products.Contains("milk"));
        Assert.True(products.Contains("eggs"));
    }

    [Fact]
    public void TestAddMultipleProductsYieldsCorrectAmount()
    {
        // Arrange
        ShoppingCart cart = new();
        cart.AddItem("beer", 3);
        cart.AddItem("milk", 1);
        cart.AddItem("bread", 5);
        cart.AddItem("beer", 5);
        cart.AddItem("milk", 1);
        cart.AddItem("bread", 1);

        // Act/Assert
        Assert.Equal(cart.GetAmountFor("beer"), 8);
        Assert.Equal(cart.GetAmountFor("milk"), 2);
        Assert.Equal(cart.GetAmountFor("bread"), 6);
    }
}