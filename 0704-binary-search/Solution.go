package Leetcode

func search(nums []int, target int) int {
	leftIndex := 0
	rightIndex := len(nums) - 1

	for leftIndex <= rightIndex {
		middleIndex := (leftIndex + rightIndex) / 2
		if nums[middleIndex] == target {
			return middleIndex
		} else if nums[middleIndex] < target {
			leftIndex = middleIndex + 1
		} else {
			rightIndex = middleIndex - 1
		}
	}
	return -1
}
