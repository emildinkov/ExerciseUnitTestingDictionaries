using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Tests;

public class GroupingTests
{
    [Test]
    public void Test_GroupNumbers_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> numbers = new();

        // Act
        string result = Grouping.GroupNumbers(numbers);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GroupNumbers_WithEvenAndOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> numbers = new() { 1, 2, 3, 4 };

        StringBuilder sb = new();
        sb.AppendLine("Odd numbers: 1, 3");
        sb.AppendLine("Even numbers: 2, 4");

        string expected = sb.ToString().Trim();

        // Act
        string result = Grouping.GroupNumbers(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GroupNumbers_WithOnlyEvenNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> numbers = new() { 2, 4, 6, 8 };

        // Act
        string result = Grouping.GroupNumbers(numbers);

        // Assert
        Assert.That(result, Is.EqualTo("Even numbers: 2, 4, 6, 8"));

    }

    [Test]
    public void Test_GroupNumbers_WithOnlyOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> numbers = new() { 1, 3, 5, 7 };

        // Act
        string result = Grouping.GroupNumbers(numbers);

        // Assert
        Assert.That(result, Is.EqualTo("Odd numbers: 1, 3, 5, 7"));

    }

    [Test]
    public void Test_GroupNumbers_WithNegativeNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> numbers = new() { -1, -2, -3, -4 };

        StringBuilder sb = new();
        sb.AppendLine("Odd numbers: -1, -3");
        sb.AppendLine("Even numbers: -2, -4");

        string expected = sb.ToString().Trim();

        // Act
        string result = Grouping.GroupNumbers(numbers);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
