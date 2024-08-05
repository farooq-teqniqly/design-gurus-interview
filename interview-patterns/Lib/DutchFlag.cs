namespace Lib;
public class DutchFlag
{
    public static int[] Sort(int[] arr)
    {
        var low = 0;
        var high = arr.Length - 1;

        for (var i = 0; i <= high;)
        {
            switch (arr[i])
            {
                case 0:
                    Swap(arr, i, low);
                    i++;
                    low++;
                    break;
                case 1:
                    i++;
                    break;
                default:
                    Swap(arr, i, high);
                    high--;
                    break;
            }
        }
        return arr;
    }

    private static void Swap(int[] arr, int firstIndex, int secondIndex)
    {
        (arr[secondIndex], arr[firstIndex]) = (arr[firstIndex], arr[secondIndex]);
    }
}
