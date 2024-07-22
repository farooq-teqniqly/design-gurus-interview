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
            if (arr[nextNonDuplicate - 1] != arr[i])
            {
                arr[nextNonDuplicate] = arr[i];
                nextNonDuplicate++;
            }
        }

        return nextNonDuplicate;
    }
}
