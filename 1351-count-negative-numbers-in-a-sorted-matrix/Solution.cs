using System.Runtime.InteropServices;

public class Solution {
    public int CountNegatives(int[][] grid)
    {
        int negatives = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            int index = SearchInsert(grid[i], -1);
            negatives += grid[i].Length - index;
        }
        return negatives;
    }
    private int SearchInsert(int[] nums, int target)
    {
        var leftIndex = 0;
        var rightIndex = nums.Length - 1;
        while (leftIndex <= rightIndex)
        {
            var middleIndex = (leftIndex + rightIndex) / 2;
            if (nums[middleIndex] <= target)
            {
                rightIndex = middleIndex - 1;
            }
            else
            {
                leftIndex = middleIndex + 1;
            }
        }

        return leftIndex;
    }
}