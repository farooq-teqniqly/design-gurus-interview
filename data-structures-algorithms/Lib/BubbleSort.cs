using System.Collections.Concurrent;
using System.Threading.Tasks.Sources;

namespace Lib;

public class QuickSort : ISortStrategy
{
    public void Sort(int[] input)
    {
        if (input.Length <= 1)
        {
            return;
        }

        QuickSortRecursive(input, 0, input.Length - 1);

    }

    private void QuickSortRecursive(int[] input, int left, int right)
    {
        if (right - left <= 0)
        {
            return;
        }

        var pivot = input[right];
        var partition = Partition(input, left, right, pivot);
        QuickSortRecursive(input, left, partition - 1);
        QuickSortRecursive(input, partition + 1, right);
    }

    private int Partition(int[] input, int left, int right, int pivot)
    {
        var leftPointer = left - 1;
        var rightPointer = right;

        while (true)
        {
            while (input[++leftPointer] < pivot)
            {
                ;
            }

            while (rightPointer > 0 && input[--rightPointer] > pivot)
            {
                ;
            }

            if (leftPointer >= rightPointer)
            {
                break;
            }

            Swap(input, leftPointer, rightPointer);
        }

        Swap(input, leftPointer, right);

        return leftPointer;
    }

    private void Swap(int[] input, int x, int y)
    {
        (input[x], input[y]) = (input[y], input[x]);
    }
}

public class BubbleSort : ISortStrategy
{
    public void Sort(int[] input)
    {
        ArgumentNullException.ThrowIfNull(input);

        if (input.Length <= 1)
        {
            return;
        }

        for (var i = 0; i < input.Length; i++)
        {
            for (var j = 0; j < input.Length - i - 1; j++)
            {
                if (input[j] > input[j + 1])
                {
                    (input[j + 1], input[j]) = (input[j], input[j + 1]);
                }
            }
        }
    }
}
