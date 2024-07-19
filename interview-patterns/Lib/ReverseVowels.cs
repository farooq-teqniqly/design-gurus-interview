namespace Lib;
public class ReverseVowels
{
    static readonly string vowels = "aeiouAEIOU";

    public static string Reverse(string s)
    {
        var arr = s.ToCharArray();
        var leftPointerIndex = 0;
        var rightPointerIndex = s.Length - 1;

        while (leftPointerIndex < rightPointerIndex)
        {
            var leftIsVowel = IsVowel(arr, leftPointerIndex);
            var rightIsVowel = IsVowel(arr, rightPointerIndex);

            if (leftIsVowel && rightIsVowel)
            {
                Swap(arr, leftPointerIndex, rightPointerIndex);
                leftPointerIndex++;
                rightPointerIndex--;

                continue;
            }

            if (!leftIsVowel)
            {
                leftPointerIndex++;
            }

            if (!rightIsVowel)
            {
                rightPointerIndex--;
            }
        }

        return new string(arr);
    }

    private static void Swap(char[] arr, int leftPointerIndex, int rightPointerIndex)
    {
        (arr[leftPointerIndex], arr[rightPointerIndex]) = (arr[rightPointerIndex], arr[leftPointerIndex]);
    }

    private static bool IsVowel(char[] arr, int leftPointerIndex)
    {
        return vowels.Contains(arr[leftPointerIndex]);
    }
}
