namespace Lib;

public class LinqValidAnagramStrategy : ValidAnagramStrategy
{
    protected override bool ValidateAnagram(string s, string t)
    {
        return s.ToLower()
            .OrderBy(ch => ch)
            .SequenceEqual(t.ToLower().OrderBy(ch => ch));
    }
}
