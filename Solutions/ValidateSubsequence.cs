namespace TinasAlgorithms
{
    internal class ValidateSubsequence
    {
        public static bool IsValidSubsequence(List<int> array, List<int> sequence)
        {
            int i = 0, j = 0;
            bool isSub = false;

            while (i < array.Count && j < sequence.Count)
            {
                if (array[i] == sequence[j]) j++;

                i++;
            }

            if (j == sequence.Count) isSub = true;

            return isSub;

        }
    }
}
