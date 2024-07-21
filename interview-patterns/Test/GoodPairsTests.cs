using FluentAssertions;
using Lib;

namespace Test;
public class GoodPairsTests
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 1, 1, 3 }, 4)]
    [InlineData(new[] { 1, 1, 1, 1 }, 6)]
    [InlineData(new[] { 1, 2, 3 }, 0)]
    [InlineData(new[] { 1 }, 0)]
    [InlineData(new int[] {}, 0)]
    public void Returns_Expected_Result(int[] nums, int expectedGoodPairCount)
    {
        GoodPairs.NumGoodPairs(nums).Should().Be(expectedGoodPairCount);
    }

    [Fact]
    public void Throws_When_Input_Is_Null()
    {
        var act = () => GoodPairs.NumGoodPairs(null!);

        act.Should().Throw<ArgumentNullException>();
    }
}
