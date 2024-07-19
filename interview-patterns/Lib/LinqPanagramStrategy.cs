namespace Lib;

public class LinqPanagramStrategy : IPanagramStrategy
{
    public char[] Alphabet { get; }

    public LinqPanagramStrategy(char[] alphabet)
    {
        Alphabet = alphabet;
    }
    public bool CheckIfPanagram(string sentence)
    {
        var leftovers = Alphabet.Except(sentence.ToLower().ToCharArray());
        return !leftovers.Any();
    }
}
