namespace Lib;

public class LinearSearch : ISearchStrategy
{
    public int Search(int[] input, int target)
    {
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