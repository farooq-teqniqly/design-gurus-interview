namespace Lib;

public class HashSetPanagramStrategy : IPanagramStrategy
{
    public char[] Alphabet { get; }

    public HashSetPanagramStrategy(char[] alphabet)
    {
        Alphabet = alphabet;
    }

    public bool CheckIfPanagram(string sentence)
    {
        var set = new HashSet<char>();

        foreach (var letter in sentence.ToLower())
        {
            if (!char.IsLetter(letter))
            {
                continue;
            }

            set.Add(letter);
        }

        return set.Count == Alphabet.Length;
    }
}
