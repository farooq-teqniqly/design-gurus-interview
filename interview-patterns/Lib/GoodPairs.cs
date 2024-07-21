namespace Lib;
public class GoodPairs
{
    public static int NumGoodPairs(int[] nums)
    {
        ArgumentNullException.ThrowIfNull(nums);

        var counts = new Dictionary<int, int>();

        var goodPairCount = 0;

        foreach (var currentNum in nums)
        {
            if (counts.TryAdd(currentNum, 1))
            {
                continue;
            }

            counts[currentNum]++;
            goodPairCount = goodPairCount + counts[currentNum] - 1;
        }

        return goodPairCount;
    }
}
