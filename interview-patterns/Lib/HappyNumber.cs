namespace Lib;

public static class HappyNumber
{
    public static bool Find(int num)
    {
        var slow = num;
        var fast = num;

        do
        {
            slow = SumOfSquares(slow);

            fast = SumOfSquares(fast);
            fast = SumOfSquares(fast);

        } while (slow != fast);

        return slow == 1;
    }
    private static int SumOfSquares(int n)
    {
        var sum = 0;

        while (n > 0)
        {
            var digit = n % 10;
            sum += digit * digit;
            n /= 10;
        }

        return sum;
    }
}
