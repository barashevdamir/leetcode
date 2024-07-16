public class Solution {
    public int[] SearchRange(int[] nums, int target)
    {
        var firstIndex = FindFirst(nums, target);
        var lastIndex = FindLast(nums, target);
        if (firstIndex <= lastIndex && lastIndex < nums.Length && nums[firstIndex] == target && nums[lastIndex] == target)
        {
            return new int[] { firstIndex, lastIndex };
        }
        else
        {
            return new int[] { -1, -1 };
        }
    }

    private int FindFirst(int[] nums, int target)
    {
        var leftIndex = 0;
        var rightIndex = nums.Length - 1;

        while (leftIndex <= rightIndex)
        {
            var middleIndex = (leftIndex + rightIndex) / 2;
            if (nums[middleIndex] < target)
            {
                leftIndex = middleIndex + 1;
            }
            else
            {
                rightIndex = middleIndex - 1;
            }
        }
        return leftIndex;
    }

    private int FindLast(int[] nums, int target)
    {
        var leftIndex = 0;
        var rightIndex = nums.Length - 1;

        while (leftIndex <= rightIndex)
        {
            var middleIndex = (leftIndex + rightIndex) / 2;
            if (nums[middleIndex] <= target)
            {
                leftIndex = middleIndex + 1;
            }
            else
            {
                rightIndex = middleIndex - 1;
            }
        }
        return rightIndex;
    }

}