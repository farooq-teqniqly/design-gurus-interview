namespace Lib;

public interface IPanagramStrategy
{
    char[] Alphabet { get; }
    bool CheckIfPanagram(string sentence);
}
