using FluentAssertions;
using Lib;

namespace Test;

public class HappyNumberTests
{
    [Theory]
    [InlineData(23, true)]
    [InlineData(12, false)]
    [InlineData(0, false)]
    public void Can_Find_Happy_Number(int n, bool expectedResult)
    {
        HappyNumber.Find(n).Should().Be(expectedResult);
    }
}
