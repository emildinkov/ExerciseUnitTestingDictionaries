using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class OddOccurrencesTests
{
    [Test]
    public void Test_FindOdd_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>();

        // Act
        string output = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(output, Is.Empty);

    }

    [Test]
    public void Test_FindOdd_WithNoOddOccurrences_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = new[] { "word", "word" };

        // Act
        string output = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(output, Is.Empty);
    }

    [Test]
    public void Test_FindOdd_WithSingleOddOccurrence_ShouldReturnTheOddWord()
    {
        // Arrange
        string[] input = new[] { "word" };

        // Act
        string output = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(output, Is.EqualTo("word"));
    }

    [Test]
    public void Test_FindOdd_WithMultipleOddOccurrences_ShouldReturnAllOddWords()
    {
        // Arrange
        string[] input = new[] {
            "the",
            "the",
            "the",
            "that"
        };

        // Act
        string output = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(output, Is.EqualTo("the that"));
    }

    [Test]
    public void Test_FindOdd_WithMixedCaseWords_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] input = new[] {
            "Word",
            "heLlo",
            "leTter"
        };

        // Act
        string output = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(output, Is.EqualTo("word hello letter"));
    }
}

