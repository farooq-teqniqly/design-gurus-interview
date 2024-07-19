using FluentAssertions;
using Lib;

namespace Test;

public class LinqPanagramStrategyTests
{
    private readonly IPanagramStrategy _panagramStrategy = new LinqPanagramStrategy();
    
    [Theory]
    [InlineData("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ", true)]
    [InlineData("TheQuickBrownFoxJumpsOverTheLazyDog", true)]
    [InlineData("The Quick Brown Fox Jumps Over The Lazy Dog", true)]
    public void Should_Return_True(string sentence, bool expectedResult)
    {
        _panagramStrategy.CheckIfPanagram(sentence).Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("This is not a pangram", false)]
    public void Should_Return_False(string sentence, bool expectedResult)
    {
        _panagramStrategy.CheckIfPanagram(sentence).Should().Be(expectedResult);
    }
}

public class HashSetPanagramStrategyTests
{
    private readonly IPanagramStrategy _panagramStrategy = new HashSetPanagramStrategy();

    [Theory]
    [InlineData("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ", true)]
    [InlineData("TheQuickBrownFoxJumpsOverTheLazyDog", true)]
    [InlineData("The Quick Brown Fox Jumps Over The Lazy Dog", true)]
    public void Should_Return_True(string sentence, bool expectedResult)
    {
        _panagramStrategy.CheckIfPanagram(sentence).Should().Be(expectedResult);
    }

    [Theory]
    [InlineData("This is not a pangram", false)]
    public void Should_Return_False(string sentence, bool expectedResult)
    {
        _panagramStrategy.CheckIfPanagram(sentence).Should().Be(expectedResult);
    }
}
