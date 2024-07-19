using System.Diagnostics.CodeAnalysis;

namespace Lib;

public class LinearSearch : ISearchStrategy
{
    public int Search(int[] input, int target)
    {
        ArgumentNullException.ThrowIfNull(input);

        if (input.Length == 0)
        {
            return ISearchStrategy.TargetNotFound;
        }

        for (var index = 0; index < input.Length; index++)
        {
            if (input[index] == target)
            {
                return index;
            }
        }

        return ISearchStrategy.TargetNotFound;
    }
}
