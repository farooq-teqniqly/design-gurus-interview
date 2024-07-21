namespace Lib;
public class GoodPairs
{
    public static int NumGoodPairs(int[] nums)
    {
        ArgumentNullException.ThrowIfNull(nums);

        var goodPairCount = 0;

        for (var first = 0; first < nums.Length - 1; first++)
        {
            for (var second = first + 1; second < nums.Length; second++)
            {
                if (nums[first] != nums[second])
                {
                    continue;
                }

                goodPairCount++;
            }
        }

        return goodPairCount;
    }
}
