namespace Lib;
public static class ShortestWordDistance
{
    public static int ShortestDistance(string[] words, string word1, string word2)
    {
        var minDistance = words.Length;
        var word1Position = -1;
        var word2Position = -1;

        for (var i = 0; i < words.Length; i++)
        {
            var currentWord = words[i];

            if (WordsMatch(word1, currentWord))
            {
                word1Position = i;
            }

            if (WordsMatch(word2, currentWord))
            {
                word2Position = i;
            }

            CalculateNewMinDistance(
                word1Position,
                word2Position,
                ref minDistance);
        }

        return minDistance;
    }

    private static void CalculateNewMinDistance(
        int word1Position,
        int word2Position,
        ref int minDistance)
    {
        if (word1Position == -1 || word2Position == -1)
        {
            return;
        }

        var distance = Math.Abs(word1Position - word2Position);

        if (distance < minDistance)
        {
            minDistance = distance;
        }
    }

    private static bool WordsMatch(string word1, string currentWord)
    {
        return string.Equals(
            word1,
            currentWord,
            StringComparison.CurrentCultureIgnoreCase);
    }
}
