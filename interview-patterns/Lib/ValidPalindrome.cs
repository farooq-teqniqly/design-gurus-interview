namespace Lib;
public class ValidPalindrome
{
    public static bool IsPalindrome(string s)
    {
        if (s.Trim().Length == 0)
        {
            return true;
        }

        var leftPointer = 0;
        var rightPointer = s.Length - 1;

        while (leftPointer <= rightPointer)
        {
            while (IgnoreCharacter(s[leftPointer]))
            {
                leftPointer++;

                if (leftPointer == s.Length)
                {
                    return true;
                }
            }

            while (IgnoreCharacter(s[rightPointer]))
            {
                rightPointer--;
            }

            if (!CharactersAreTheSame(s[leftPointer], s[rightPointer]))
            {
                return false;
            }

            leftPointer++;
            rightPointer--;
        }

        return true;
    }

    private static bool CharactersAreTheSame(char first, char second)
    {
        return char.ToLower(first) == char.ToLower(second);
    }

    private static bool IgnoreCharacter(char letter)
    {
        return !char.IsLetterOrDigit(letter);
    }
}
