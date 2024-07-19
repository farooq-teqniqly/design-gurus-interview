namespace Lib;

public class LinqPanagramStrategy : IPanagramStrategy
{
    private static readonly char[] _alphabet = "abcdefghijklmnopqrstuvwxyz".ToArray();

    public bool CheckIfPanagram(string sentence)
    {
        ArgumentNullException.ThrowIfNull(sentence);

        var leftovers = _alphabet.Except(sentence.ToLower().ToCharArray());
        return !leftovers.Any();
    }
}

public interface IPanagramStrategy
{
    bool CheckIfPanagram(string sentence);
}

