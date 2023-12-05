using NUnit.Framework;

using System;
using System.Text;

namespace TestApp.Tests;

public class CountRealNumbersTests
{
    [Test]
    public void Test_Count_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        int[] numbers = Array.Empty<int>();

        // Act
        string result = CountRealNumbers.Count(numbers);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleNumber_ShouldReturnCountString()
    {
        // Arrange
        int[] numbers = new int[] { 9 };

        // Act
        string result = CountRealNumbers.Count(numbers);

        // Assert
        Assert.That(result, Is.EqualTo("9 -> 1"));
    }

    [Test]
    public void Test_Count_WithMultipleNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] numbers = new[] { 1, 2, 3, 2, 3, 1 };

        StringBuilder sb = new();
        sb.AppendLine("1 -> 2");
        sb.AppendLine("2 -> 2");
        sb.AppendLine("3 -> 2");

        string expected = sb.ToString().Trim();

        // Act
        string result = CountRealNumbers.Count(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithNegativeNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] numbers = new[] { -1, -2, -3, -2, -3, -1 };

        StringBuilder sb = new();
        sb.AppendLine("-3 -> 2");
        sb.AppendLine("-2 -> 2");
        sb.AppendLine("-1 -> 2");

        string expected = sb.ToString().Trim();

        // Act
        string result = CountRealNumbers.Count(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithZero_ShouldReturnCountString()
    {
        // Arrange
        int[] numbers = new[] { 0, 0, 0 };

        // Act
        string result = CountRealNumbers.Count(numbers);

        // Assert
        Assert.That(result, Is.EqualTo("0 -> 3"));
    }
}
