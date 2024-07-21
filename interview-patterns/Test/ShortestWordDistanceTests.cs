using FluentAssertions;
using Lib;

namespace Test;
public class ShortestWordDistanceTests
{
    [Theory]
    [InlineData(
        new[] { "the", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog" },
        "fox",
        "dog",
        5)]
    [InlineData(new[] { "a", "c", "d", "b", "a" }, "a", "b", 1)]
    [InlineData(new[] { "a", "b", "c", "d", "e" }, "a", "e", 4)]
    [InlineData(new[] { "A", "b", "c", "d", "e" }, "a", "e", 4)]
    public void Returns_Expected_Result(
        string[] words,
        string firstWord,
        string secondWord,
        int expectedDistance)
    {
        ShortestWordDistance.ShortestDistance(
                words,
                firstWord,
                secondWord)
            .Should().Be(expectedDistance);
    }
}
