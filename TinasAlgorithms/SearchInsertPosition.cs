namespace TinasAlgorithms
{
    internal class SearchInsertPosition
    {
        public static int SearchInsert(int[] nums, int target)
        {
            int j = 0;
            int targetIndex = 0;
            if (nums.Contains(target))
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == target)
                    {
                        targetIndex = i;
                        break;
                    }
                }
            }
            else if (nums[0] > target)
            {
                targetIndex = 0;
            }
            else
            {
                do
                {
                    j++;
                    targetIndex++;
                    if (j >= nums.Length)
                    {
                        targetIndex = nums.Length;
                        break;
                    }
                } while (nums[j] < target);
            }
            return targetIndex;
        }
    }
}
