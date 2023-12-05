using NUnit.Framework;

using System;
using System.Text;

namespace TestApp.Tests;

public class PlantsTests
{
    [Test]
    public void Test_GetFastestGrowing_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>();

        // Act
        string output = Plants.GetFastestGrowing(input);

        // Assert
        Assert.That(output, Is.Empty);
    }

    [Test]
    public void Test_GetFastestGrowing_WithSinglePlant_ShouldReturnPlant()
    {
        // Arrange
        string[] input = new[] { "flower" };

        // Act
        string output = Plants.GetFastestGrowing(input);

        // Assert
        Assert.That (output, Is.EqualTo($"Plants with 6 letters:{Environment.NewLine}flower"));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMultiplePlants_ShouldReturnGroupedPlants()
    {
        // Arrange
        string[] input = new[] {
            "flower",
            "mack",
            "lily"
        };

        StringBuilder sb = new();
        sb.AppendLine("Plants with 4 letters:");
        sb.AppendLine("mack");
        sb.AppendLine("lily");
        sb.AppendLine("Plants with 6 letters:");
        sb.AppendLine("flower");

        string expected = sb.ToString().Trim();

        // Act
        string output = Plants.GetFastestGrowing(input);

        // Assert
        Assert.That(output, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMixedCasePlants_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] input = new[] {
            "Flower",
            "maCk",
            "lilY"
        };

        StringBuilder sb = new();
        sb.AppendLine("Plants with 4 letters:");
        sb.AppendLine("maCk");
        sb.AppendLine("lilY");
        sb.AppendLine("Plants with 6 letters:");
        sb.AppendLine("Flower");

        string expected = sb.ToString().Trim();

        // Act
        string output = Plants.GetFastestGrowing(input);

        // Assert
        Assert.That(output, Is.EqualTo(expected));
    }
}
