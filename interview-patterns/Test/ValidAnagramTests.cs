using FluentAssertions;
using Lib;

namespace Test;
public class ValidAnagramTests
{
    [Theory]
    [InlineData("silent", "listen", true)]
    [InlineData("rat", "car", false)]
    [InlineData("a", "aa", false)]
    [InlineData(" ", " ", true)]
    public void Returns_Expected_Result(string first, string second, bool expectedResult)
    {
        ValidAnagram.IsAnagram(first, second).Should().Be(expectedResult);
    }
}
