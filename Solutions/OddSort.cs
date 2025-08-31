namespace TinasAlgorithms
{
    internal class OddSort
    {
        public static int[] SortArray(int[] array)
        {
            int mn;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] > array[j] && array[j] % 2 == 1)
                        {
                            mn = array[j];
                            array[j] = array[i];
                            array[i] = mn;
                        }
                    }
                }
            }

            return array;
        }
    }
}
