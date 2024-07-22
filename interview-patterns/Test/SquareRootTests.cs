using FluentAssertions;
using Lib;

namespace Test;
public class SquareRootTests
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    [InlineData(4, 2)]
    [InlineData(8, 2)]
    [InlineData(2, 1)]
    [InlineData(2147395600, 46340)]
    public void Returns_Expected_Result(int num, int expectedSquareRoot)
    {
        SquareRoot.Calculate(num).Should().Be(expectedSquareRoot);
    }

    [Fact]
    public void Throws_When_Input_Negative()
    {
        var act = () => SquareRoot.Calculate(-1);

        act.Should().Throw<ArgumentOutOfRangeException>();
    }
}
