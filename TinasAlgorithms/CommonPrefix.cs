namespace TinasAlgorithms
{
    internal class CommonPrefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            int prefixLength = 0;
            string prefix = "";

            foreach (char c in strs[0])
            {
                foreach (string str in strs)
                {
                    if (prefixLength >= str.Length || str[prefixLength] != c)
                    {
                        return prefix;
                    }
                }
                prefix += c;
                prefixLength++;
            }

            return prefix;
        }
    }
}
