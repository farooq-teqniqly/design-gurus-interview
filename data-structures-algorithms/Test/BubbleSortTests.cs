using FluentAssertions;
using Lib;

namespace Test;

public class QuickSortTests
{
    [Theory]
    [InlineData(new[] { 64, 34, 25, 12, 22, 11, 90 })]
    [InlineData(new[] { 64 })]
    [InlineData(new[] { 64, 12 })]
    [InlineData(new[] { 1, 2, 3, 4, 5, 6 })]
    [InlineData(new int[] { })]
    public void Sort_Sorts_Array_In_Place(int[] input)
    {
        var copy = new int[input.Length];
        Array.Copy(input, copy, input.Length);

        new QuickSort().Sort(input);

        copy.AsEnumerable().Order().Should().Equal(input);
    }
}
public class BubbleSortTests
{
    [Theory]
    [InlineData(new[] { 64, 34, 25, 12, 22, 11, 90 })]
    [InlineData(new[] { 64 })]
    [InlineData(new[] { 64, 12 })]
    [InlineData(new[] { 1, 2, 3, 4, 5, 6})]
    [InlineData(new int[] {})]
    public void Sort_Sorts_Array_In_Place(int[] input)
    {
        var copy = new int[input.Length];
        Array.Copy(input, copy, input.Length);

        new BubbleSort().Sort(input);

        copy.AsEnumerable().Order().Should().Equal(input);
    }

    [Fact]
    public void Sort_When_Input_Null_Throws_Exception()
    {
        var act = () => new BubbleSort().Sort(null!);

        act.Should().Throw<ArgumentNullException>();
    }
}
