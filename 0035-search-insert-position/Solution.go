package Leetcode

func searchInsert(nums []int, target int) int {
	leftIndex := 0
	rightIndex := len(nums) - 1
	for leftIndex <= rightIndex {
		midIndex := (leftIndex + rightIndex) / 2
		if nums[midIndex] == target {
			return midIndex
		} else if nums[midIndex] < target {
			leftIndex = midIndex + 1
		} else {
			rightIndex = midIndex - 1
		}
	}
	return leftIndex
}
