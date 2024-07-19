using System.Runtime.InteropServices;
using FluentAssertions;
using Lib;

namespace Test;

public class ContainsDuplicateTests
{
    [Theory]
    [InlineData(new int[] {1, 2, 3, 4}, false)]
    [InlineData(new int[] { 1 }, false)]
    [InlineData(new int[] {}, false)]
    public void Should_Return_False(int[] nums, bool expectedResult)
    {
        ContainsDuplicate.Execute(nums).Should().Be(expectedResult);
    }

    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 2 }, true)]
    [InlineData(new int[] { 1, 1 }, true)]
    [InlineData(new int[] { 1, 2, 3, 2, 2, 2}, true)]
    public void Should_Return_True(int[] nums, bool expectedResult)
    {
        ContainsDuplicate.Execute(nums).Should().Be(expectedResult);
    }

}
