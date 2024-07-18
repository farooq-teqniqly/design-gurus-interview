using FluentAssertions;
using Lib;

namespace Test;

public class LinearSearchTests
{
    [Theory]
    [InlineData(new[] { 2, 3, 4, 10, 40 }, 40, 4)]
    [InlineData(new[] { 2, 3, 4, 10, 40 }, 4, 2)]
    [InlineData(new[] { 2, 3, 4, 10 }, 10, 3)]
    [InlineData(new[] { 2, 3, 4, 10 }, 2, 0)]
    [InlineData(new[] { 2, 3, 4, 10 }, 3, 1)]
    [InlineData(new[] { 2, 3, 4, 10 }, 4, 2)]
    public void Search_Returns_Expected_Result(int[] input, int target, int expectedIndex)
    {
        new LinearSearch().Search(input, target).Should().Be(expectedIndex);
    }

    [Theory]
    [InlineData(new[] { 2, 3, 4, 10, 40 }, 50)]
    [InlineData(new[] { 2, 3, 4, 10 }, 50)]
    public void Search_When_Target_Not_Found_Returns_Not_Found(int[] input, int target)
    {
        new LinearSearch().Search(input, target).Should().Be(ISearchStrategy.TargetNotFound);
    }

    [Fact]
    public void Search_Returns_Not_Found_When_Array_Is_Empty()
    {
        new LinearSearch().Search([], 10).Should().Be(ISearchStrategy.TargetNotFound);
    }
}
