using FluentAssertions;
using Lib;

namespace Test;
public class FindNonDuplicatesTests
{
    [Theory]
    [InlineData(new[] { 2, 3, 3, 3, 6, 9, 9 }, 4)]
    [InlineData(new[] { 2, 2, 2, 11 }, 2)]
    [InlineData(new[] { 2, 2 }, 1)]
    [InlineData(new[] { 2 }, 1)]
    [InlineData(new[] { 1, 2 }, 2)]
    public void Returns_Expected_Result(int[] input, int expectedCount)
    {
        FindNonDuplicates.MoveElements(input).Should().Be(expectedCount);
    }
}
