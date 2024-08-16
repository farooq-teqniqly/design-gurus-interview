namespace Lib;

public static class PairWithTargetSum
{
    public static int[] Search(int[] arr, int targetSum)
    {
        ArgumentNullException.ThrowIfNull(arr);

        var notFound = new[] { -1, -1 };

        if (arr.Length == 0)
        {
            return notFound;
        }

        var left = 0;
        var right = arr.Length - 1;

        while(left < right)
        {
            var sum = arr[left] + arr[right];

            if (sum > targetSum)
            {
                right--;
            }
            else if (sum < targetSum)
            {
                left++;
            }
            else
            {
                return [left, right];
            }
        }

        return notFound;
    }
}
