namespace Lib;
public static class HappyNumber
{
    public static bool Find(int num)
    {
        var set = new HashSet<int>();

        while (num != 1 && !set.Contains(num))
        {
            set.Add(num);
            num = SumOfSquares(num);
        }

        return num == 1;
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

