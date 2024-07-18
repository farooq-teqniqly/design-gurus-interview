namespace Lib;

public class LinearSearch : ISearchStrategy
{
    public int Search(int[] input, int target)
    {
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
