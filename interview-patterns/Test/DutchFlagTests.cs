using FluentAssertions;
using Lib;

namespace Test;

public class DutchFlagTests
{
    [Theory]
    [InlineData(new[] { 1, 0, 2, 1, 0 }, new[] { 0, 0, 1, 1, 2 })]
    [InlineData(new[] { 2, 2, 0, 1, 2, 0 }, new[] { 0, 0, 1, 2, 2, 2 })]
    public void Can_Sort(int[] input, int[] expected)
    {
        DutchFlag.Sort(input).Should().Equal(expected);
    }
}
