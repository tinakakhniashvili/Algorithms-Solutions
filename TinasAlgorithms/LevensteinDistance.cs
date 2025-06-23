namespace TinasAlgorithms;

public class LevensteinDistance
{
    static int LevenshteinDistance(string s1, string s2)
    {
        int len1 = s1.Length;
        int len2 = s2.Length;
        int[,] dp = new int[len1 + 1, len2 + 1];

        for (int i = 0; i <= len1; i++)
            dp[i, 0] = i;
        for (int j = 0; j <= len2; j++)
            dp[0, j] = j;

        for (int i = 1; i <= len1; i++)
        {
            for (int j = 1; j <= len2; j++)
            {
                int cost = (s1[i - 1] == s2[j - 1]) ? 0 : 1;
                dp[i, j] = Math.Min(Math.Min(
                        dp[i - 1, j] + 1,      // Deletion
                        dp[i, j - 1] + 1),     // Insertion
                    dp[i - 1, j - 1] + cost    // Substitution
                );
            }
        }

        return dp[len1, len2];
    }
}