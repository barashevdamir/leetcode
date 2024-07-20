package Leetcode

func searchRange(nums []int, target int) []int {
	first := findFirst(nums, target)
	last := findLast(nums, target)
	if first <= last && last < len(nums) && nums[first] == target && nums[last] == target {
		return []int{first, last}
	} else {
		return []int{-1, -1}
	}
}

func findFirst(nums []int, target int) int {
	left := 0
	right := len(nums) - 1

	for left <= right {
		mid := (left + right) / 2
		if nums[mid] >= target {
			right = mid - 1
		} else {
			left = mid + 1
		}
	}
	return left
}

func findLast(nums []int, target int) int {
	left := 0
	right := len(nums) - 1
	for left <= right {
		mid := (left + right) / 2
		if nums[mid] <= target {
			left = mid + 1
		} else {
			right = mid - 1
		}
	}
	return right
}
