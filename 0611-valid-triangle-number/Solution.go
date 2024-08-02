package Leetcode

import "sort"

func triangleNumber(nums []int) int {
	sort.Ints(nums)
	count := 0

	for i := 2; i < len(nums); i++ {
		left, right := 0, i-1
		for left < right {
			if nums[left]+nums[right] > nums[i] {
				count += right - left
				right--
			} else {
				left++
			}
		}
	}
	return count
}
