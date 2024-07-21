namespace Lib;

public class LinqValidAnagramStrategy : IValidAnagramStrategy
{
    public bool IsAnagram(string s, string t)
    {
        ArgumentException.ThrowIfNullOrEmpty(s);
        ArgumentException.ThrowIfNullOrEmpty(t);

        if (s.Length != t.Length)
        {
            return false;
        }

        return s.ToLower()
            .OrderBy(ch => ch)
            .SequenceEqual(t.ToLower().OrderBy(ch => ch));
    }
}
