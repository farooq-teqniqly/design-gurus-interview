namespace Lib;

public class HashSetValidAnagramStrategy : ValidAnagramStrategy
{
    private readonly Dictionary<char, int> _counts = new();

    protected override bool ValidateAnagram(string s, string t)
    {
        foreach (var ch in s)
        {
            var lower = char.ToLower(ch);

            if (!_counts.TryAdd(lower, 1))
            {
                _counts[lower] += 1;
            }
        }

        foreach (var ch in t)
        {
            var lower = char.ToLower(ch);

            if (!_counts.ContainsKey(lower))
            {
                return false;
            }

            _counts[lower] -= 1;
        }

        return _counts.All(entry => entry.Value == 0);
    }
}
