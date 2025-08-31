namespace TinasAlgorithms
{
    internal class SortedMatrixSearch
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            foreach (int[] row in matrix)
            {
                if (row.Contains(target)) return true;
            }
            return false;
        }
    }
}
