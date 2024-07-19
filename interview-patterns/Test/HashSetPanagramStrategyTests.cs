using FluentAssertions;
using Lib;

namespace Test;

public class HashSetPanagramStrategyTests
{
    private static readonly char[] _alphabet = "abcdefghijklmnopqrstuvwxyz".ToArray();
    private readonly IPanagramStrategy _panagramStrategy = new HashSetPanagramStrategy(_alphabet);

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
