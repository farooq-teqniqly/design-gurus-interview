namespace Lib;
public class PairWithTargetSum
{
    public static int[] Search(int[] arr, int targetSum)
    {
        ArgumentNullException.ThrowIfNull(arr);

        var notFound = new[] { -1, -1 };

        if (arr.Length == 0)
        {
            return notFound;
        }

        for (var i = 0; i < arr.Length - 1; i++)
        {
            for (var j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] + arr[j] == targetSum)
                {
                    return [i, j];
                }
            }
        }

        return notFound;
    }
}
