namespace Lib;

public static class SquareRoot
{
    public static int Calculate(int x)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(x);

        if (x < 2)
        {
            return x;
        }

        var left = 2;
        var right = x / 2;

        while (left <= right)
        {
            var pivot = left + ((right - left) / 2);
            long guess = (long)pivot * pivot;

            if (guess < x)
            {
                left = pivot + 1;
            }
            else if (guess > x)
            {
                right = pivot - 1;
            }
            else
            {
                return pivot;
            }
        }

        return right;
    }
}
