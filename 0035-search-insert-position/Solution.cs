public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        var leftIndex = 0;
        var rightIndex = nums.Length - 1;
        while (leftIndex <= rightIndex)
        {
            var middleIndex = (leftIndex + rightIndex) / 2;
            if (nums[middleIndex] == target)
            {
                return middleIndex;
            }
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
}
