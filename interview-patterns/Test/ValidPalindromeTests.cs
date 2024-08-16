using FluentAssertions;
using Lib;

namespace Test;

public class ValidPalindromeTests
{
    [Theory]
    [InlineData("A man, a plan, a canal, Panama!", true)]
    [InlineData("Was it a car or a cat I saw?", true)]
    [InlineData("Was it a car or a cat we saw?", false)]
    [InlineData("a", true)]
    [InlineData("  a     ", true)]
    [InlineData("  a    b    b        a ", true)]
    [InlineData("12321", true)]
    [InlineData("   ", true)]
    [InlineData(",,,", true)]
    [InlineData(",-,", true)]
    public void Returns_Expected_Result(string input, bool expectedResult)
    {
        ValidPalindrome.IsPalindrome(input).Should().Be(expectedResult);
    }
}
