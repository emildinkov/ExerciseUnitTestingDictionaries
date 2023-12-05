using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Tests;

public class CountCharactersTests
{
    [Test]
    public void Test_Count_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithNoCharacters_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new() { "" };

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleCharacter_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "a" };

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That (result, Is.EqualTo("a -> 1"));
    }

    [Test]
    public void Test_Count_WithMultipleCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { 
            "abc",
            "bca",
            "cba"
        };

        StringBuilder sb = new();
        sb.AppendLine("a -> 3");
        sb.AppendLine("b -> 3");
        sb.AppendLine("c -> 3");

        string expected = sb.ToString().Trim();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithSpecialCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() {
            "abc!",
            "bca@",
            "cba!"
        };

        StringBuilder sb = new();
        sb.AppendLine("a -> 3");
        sb.AppendLine("b -> 3");
        sb.AppendLine("c -> 3");
        sb.AppendLine("! -> 2");
        sb.AppendLine("@ -> 1");

        string expected = sb.ToString().Trim();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithOnlyDigits_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() {
            "123",
            "231",
            "321"
        };

        StringBuilder sb = new();
        sb.AppendLine("1 -> 3");
        sb.AppendLine("2 -> 3");
        sb.AppendLine("3 -> 3");

        string expected = sb.ToString().Trim();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
