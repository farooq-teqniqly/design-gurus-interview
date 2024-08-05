namespace Lib;
public static class DutchFlag
{
    public static int[] Sort(int[] arr)
    {
        var low = 0;
        var high = arr.Length - 1;

        for (var i = 0; i <= high;)
        {
            if (arr[i] == 0)
            {
                Swap(arr, i, low);
                i++;
                low++;
            }
            else if (arr[i] == 1)
            {
                i++;
            }
            else
            {
                Swap(arr, i, high);
                high--;
            }
        }
        return arr;
    }

    private static void Swap(int[] arr, int firstIndex, int secondIndex)
    {
        (arr[secondIndex], arr[firstIndex]) = (arr[firstIndex], arr[secondIndex]);
    }
}
