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
    public void MoveElements_Returns_Expected_Result(int[] input, int expectedCount)
    {
        FindNonDuplicates.MoveElements(input).Should().Be(expectedCount);
    }

    [Theory]
    [InlineData(new[] {3, 2, 3, 6, 3, 10, 9, 3 }, 3, 4)]
    [InlineData(new[] { 2, 11, 2, 2, 1 }, 2, 2)]
    [InlineData(new int[]{ }, 2, 0)]
    [InlineData(new[] { 1 }, 1, 0)]
    [InlineData(new[] { 1 }, 2, 1)]
    public void Remove_Returns_Expected_Result(int[] input, int key, int expectedCount)
    {
        FindNonDuplicates.Remove(input, key).Should().Be(expectedCount);
    }
}
