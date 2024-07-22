using FluentAssertions;
using Lib;

namespace Test;
public class PairWithTargetSumTests
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 4, 6 }, 6, new[] { 1, 3 })]
    [InlineData(new[] { 2, 5, 9, 11 }, 11, new[] { 0, 2 })]
    [InlineData(new[] { 2, 5, 9, 11 }, 8, new[] { -1, -1 })]
    public void Returns_Expected_Result(int[] input, int target, int[] expectedResult)
    {
        PairWithTargetSum.Search(input, target).Should().Equal(expectedResult);
    }
}
