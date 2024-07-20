package Leetcode

func countNegatives(grid [][]int) int {
	var negatives = 0
	for i := 0; i < len(grid); i++ {
		var index = searchInsert(grid[i], -1)
		negatives += len(grid[i]) - index
	}
	return negatives

}

func searchInsert(nums []int, target int) int {
	var left = 0
	var right = len(nums) - 1
	for left <= right {
		var mid = (left + right) / 2
		if nums[mid] <= target {
			right = mid - 1
		} else {
			left = mid + 1
		}
	}
	return left
}
