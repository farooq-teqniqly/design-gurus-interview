namespace Lib;

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
