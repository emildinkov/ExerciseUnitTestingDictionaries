using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class OrdersTests
{
    [Test]
    public void Test_Order_WithEmptyInput_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>();

        // Act
        string output = Orders.Order(input);

        // Assert
        Assert.That(output, Is.Empty);
    }

    [Test]
    public void Test_Order_WithMultipleOrders_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new string[] {
            "apple 1.99 3",
            "banana 1.25 3",
            "orange 0.66 3"
        };

        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo($"apple -> 5.97{Environment.NewLine}banana -> 3.75{Environment.NewLine}orange -> 1.98"));
    }

    [Test]
    public void Test_Order_WithRoundedPrices_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new string[] {
            "apple 2.00 3",
            "banana 2.00 2",
            "orange 1.00 2"
        };

        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo($"apple -> 6.00{Environment.NewLine}banana -> 4.00{Environment.NewLine}orange -> 2.00"));
    }

    [Test]
    public void Test_Order_WithDecimalQuantities_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new string[] {
            "apple 1.99 3.50",
            "banana 1.25 3.20",
            "orange 0.66 3.80"
        };

        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo($"apple -> 6.97{Environment.NewLine}banana -> 4.00{Environment.NewLine}orange -> 2.51"));
    }
}
