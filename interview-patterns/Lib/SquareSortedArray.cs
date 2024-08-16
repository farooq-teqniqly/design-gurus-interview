namespace Lib;

public static class SquareSortedArray
{
    public static int[] MakeSquares(int[] arr)
    {
        var length = arr.Length;
        var targetArr = new int[length];
        var leftIndex = 0;
        var rightIndex = length - 1;
        var targetIndex = length - 1;

        while (leftIndex <= rightIndex)
        {
            var leftNum = arr[leftIndex];
            var rightNum = arr[rightIndex];

            var leftSquared = leftNum * leftNum;
            var rightSquared = rightNum * rightNum;

            if (leftSquared > rightSquared)
            {
                targetArr[targetIndex] = leftSquared;
                leftIndex++;
            }
            else
            {
                targetArr[targetIndex] = rightSquared;
                rightIndex--;
            }

            targetIndex--;
        }

        return targetArr;
    }
}
