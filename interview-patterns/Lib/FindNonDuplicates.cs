namespace Lib;
public class FindNonDuplicates
{
    public static int MoveElements(int[] arr)
    {
        ArgumentNullException.ThrowIfNull(arr);

        switch (arr.Length)
        {
            case 0:
                throw new ArgumentOutOfRangeException(nameof(arr));
            case 1:
                return 1;
        }

        var nextNonDuplicate = 1;

        for (var i = 1; i < arr.Length; i++)
        {
            if (arr[nextNonDuplicate - 1] == arr[i])
            {
                continue;
            }

            arr[nextNonDuplicate] = arr[i];
            nextNonDuplicate++;
        }

        return nextNonDuplicate;
    }

    public static int Remove(int[] arr, int key)
    {
        ArgumentNullException.ThrowIfNull(arr);

        if (arr.Length == 0)
        {
            return 0;
        }

        var nextNonKeyIndex = 0;

        for (var i = 0; i < arr.Length; i++)
        {
            if (arr[i] == key)
            {
                continue;
            }

            arr[nextNonKeyIndex] = arr[i];
            nextNonKeyIndex++;
        }

        return nextNonKeyIndex;
    }
}
