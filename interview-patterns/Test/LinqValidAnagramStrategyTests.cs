using FluentAssertions;
using Lib;

namespace Test;

public class HashSetValidAnagramStrategyTests
{
    private readonly IValidAnagramStrategy _strategy = new HashSetValidAnagramStrategy();

    [Theory]
    [InlineData("silent", "listen", true)]
    [InlineData("rat", "car", false)]
    [InlineData("a", "aa", false)]
    [InlineData(" ", " ", true)]
    [InlineData("hello", "world", false)]
    [InlineData("SilENT", "lIsTen", true)]
    public void Returns_Expected_Result(string first, string second, bool expectedResult)
    {
        _strategy.IsAnagram(first, second).Should().Be(expectedResult);
    }
}


public class LinqValidAnagramStrategyTests
{
    private readonly IValidAnagramStrategy _strategy = new LinqValidAnagramStrategy();

    [Theory]
    [InlineData("silent", "listen", true)]
    [InlineData("rat", "car", false)]
    [InlineData("a", "aa", false)]
    [InlineData(" ", " ", true)]
    public void Returns_Expected_Result(string first, string second, bool expectedResult)
    {
        _strategy.IsAnagram(first, second).Should().Be(expectedResult);
    }
}
