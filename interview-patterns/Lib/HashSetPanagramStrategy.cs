namespace Lib;

public class HashSetPanagramStrategy : IPanagramStrategy
{
    private static readonly char[] _alphabet = "abcdefghijklmnopqrstuvwxyz".ToArray();

    public bool CheckIfPanagram(string sentence)
    {
        ArgumentNullException.ThrowIfNull(sentence);

        var set = new HashSet<char>();

        foreach (var letter in sentence.ToLower())
        {
            if (!char.IsLetter(letter))
            {
                continue;
            }

            set.Add(letter);
        }

        return set.Count == _alphabet.Length;
    }
}
