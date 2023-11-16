namespace TinasAlgorithms
{
    internal class ExtractFirstKWords
    {
        public string TruncateSentence(string s, int k)
        {
            string[] words = s.Split(' ');
            string extractedWords = "";
            for (int i = 0; i < k; i++)
            {
                if (i != (k - 1))
                    extractedWords += words[i] + " ";
                else
                    extractedWords += words[i];
            }
            return extractedWords;
        }
    }
}
