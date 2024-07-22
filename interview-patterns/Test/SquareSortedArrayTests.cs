using FluentAssertions;
using Lib;

namespace Test;
public class SquareSortedArrayTests
{
    [Theory]
    [InlineData(new[] { -2, -1, 0, 2, 3 }, new[] { 0, 1, 4, 4, 9 })]
    [InlineData(new[] { -3, -1, 0, 1, 2 }, new[] { 0, 1, 1, 4, 9 })]
    public void Returns_Expected_Result(int[] original, int[] expected)
    {
        SquareSortedArray.MakeSquares(original).Should().Equal(expected);
    }
}
