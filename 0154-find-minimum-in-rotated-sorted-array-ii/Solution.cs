public class Solution {
    public int FindMin(int[] nums)
    {
        var left = 0;
        var right = nums.Length - 1;
        
        while (left < right)
        {
            if (nums[right] == nums[left])
            {
                right--;
                continue;
            }
            var mid = left + (right - left) / 2;
            if (nums[mid] > nums[right])
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }
        
        return nums[left];
    }
}
// [3,3,1,3]