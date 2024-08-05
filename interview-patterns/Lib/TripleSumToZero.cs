namespace Lib;
public class TripleSumToZero
{
    public static List<List<int>> SearchTriplets(int[] arr)
    {
        var triplets = new List<List<int>>();

        Array.Sort(arr);

        for (var i = 0; i < arr.Length - 2; i++)
        {
            if (i > 0 && arr[i] == arr[i - 1])
            {
                continue;
            }

            SearchTriplets(arr, -arr[i], i + 1, triplets);
        }

        return triplets;
    }

    private static void SearchTriplets(
        int[] arr,
        int target,
        int leftIndex,
        List<List<int>> triplets)
    {
        var rightIndex = arr.Length - 1;

        while (leftIndex < rightIndex)
        {
            var sum = arr[leftIndex] + arr[rightIndex];

            if (sum == target)
            {
                triplets.Add([-sum, arr[leftIndex], arr[rightIndex]]);
                leftIndex++;
                rightIndex--;

                while (leftIndex < rightIndex && arr[leftIndex] == arr[leftIndex - 1])
                {
                    leftIndex++;
                }

                while (leftIndex < rightIndex && arr[rightIndex] == arr[rightIndex + 1])
                {
                    rightIndex--;
                }
            }
            else if (sum < target)
            {
                leftIndex++;
            }
            else
            {
                rightIndex--;
            }
        }
    }
}
