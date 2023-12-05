namespace TinasAlgorithms
{
    internal class BinarySearch
    {
        public int Search(int[] nums, int target)
        {

            int left = 0;
            int right = nums.Length - 1;
            int middle = (left + right) / 2;

            while (nums[middle] != target)
            {
                if (target > nums[middle])
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }

                if (left > right)
                {
                    return -1;
                }

                middle = (left + right) / 2;
            }

            return middle;
        }
    }
}
