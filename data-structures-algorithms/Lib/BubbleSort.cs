namespace Lib;

public class BubbleSort : ISortStrategy
{
    public void Sort(int[] input)
    {
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