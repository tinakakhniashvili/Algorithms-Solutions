namespace TinasAlgorithms
{
    internal class StringShuffling
    {
        public string RestoreString(string s, int[] indices)
        {
            int n = indices.Length;
            char[] resultArray = new char[n];

            for (int i = 0; i < n; i++)
            {
                int Index = -1;
                for (int j = 0; j < n; j++)
                {
                    if (indices[j] == i) Index = j;
                }

                resultArray[i] = s[Index];
            }

            return new string(resultArray);
        }
    }
}
