namespace Lib;

public abstract class ValidAnagramStrategy : IValidAnagramStrategy
{
    public bool IsAnagram(string s, string t)
    {
        ArgumentException.ThrowIfNullOrEmpty(s);
        ArgumentException.ThrowIfNullOrEmpty(t);

        if (s.Length != t.Length)
        {
            return false;
        }

        return ValidateAnagram(s, t);
    }

    protected abstract bool ValidateAnagram(string s, string t);
}
