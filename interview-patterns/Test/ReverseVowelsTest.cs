using FluentAssertions;
using Lib;

namespace Test;
public class ReverseVowelsTest
{
    [Theory]
    [InlineData("hello", "holle")]
    [InlineData("AEIOU", "UOIEA")]
    [InlineData("DesignGUrus", "DusUgnGires")]
    public void Should_Reverse_Vowels(string original, string expected)
    {
        ReverseVowels.Reverse(original).Should().Be(expected);
    }
}
