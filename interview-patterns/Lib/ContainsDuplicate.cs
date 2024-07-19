namespace Lib;

public class ContainsDuplicate
{
    public static bool Execute(int[] nums)
    {
        ArgumentNullException.ThrowIfNull(nums);

        if (nums.Length <= 1)
        {
            return false;
        }

        var set = new HashSet<int>();

        foreach (var num in nums)
        {
            if (!set.Add(num))
            {
                return true;
            }
        }

        return false;
    }
}
