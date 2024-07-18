namespace Lib;

public class BinarySearch : ISearchStrategy
{
    public int Search(int[] input, int target)
    {
        var low = 0;
        var high = input.Length - 1;

        while (low <= high)
        {
            var mid = (low + high) / 2;

            if (input[mid] < target)
            {
                low = mid + 1;
            }
            else if (input[mid] > target)
            {
                high = mid - 1;
            }
            else
            {
                return mid;
            }
        }

        return ISearchStrategy.TargetNotFound;
    }
}
