public class Solution {
    public int TriangleNumber(int[] nums)
    {
        Array.Sort(nums);
        int count = 0;
        for (int i = 2; i < nums.Length; ++i)
        {
            int left = 0;
            int right = i - 1;
            while (left < right)
            {
                if (nums[left] + nums[right] > nums[i])
                {
                    count += right - left;
                    right--;
                }
                else
                {
                    left++;
                }
            }
        }

        return count;
    }

}
