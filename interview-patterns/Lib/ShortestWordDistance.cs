namespace Lib;
public class ShortestWordDistance
{
    public static int ShortestDistance(string[] words, string word1, string word2)
    {
        var positions = new Dictionary<string, List<int>>();

        for(var i = 0; i < words.Length; i++)
        {
            var key = words[i];

            if (!positions.ContainsKey(key))
            {
                positions.Add(key, [i]);
            }
            else
            {
                positions[key].Add(i);
            }
        }

        var minDistance = int.MaxValue;

        foreach (var word1Position in positions[word1])
        {
            foreach (var word2Position in positions[word2])
            {
                var distance = Math.Abs(word1Position - word2Position);

                if (distance < minDistance)
                {
                    minDistance = distance;
                }
            }
        }

        return minDistance;
    }
}
