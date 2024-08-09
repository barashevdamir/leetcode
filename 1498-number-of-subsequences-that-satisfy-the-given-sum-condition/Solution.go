package Leetcode

import "sort"

const MOD = 1_000_000_007

func numSubseq(nums []int, target int) int {
	sort.Ints(nums)
	result := 0
	left, right := 0, len(nums)-1
	pow := make([]int, len(nums))
	pow[0] = 1
	for i := 1; i < len(nums); i++ {
		pow[i] = (pow[i-1] * 2) % MOD
	}

	for left <= right {
		if nums[left]+nums[right] <= target {
			result = (result + pow[right-left]) % MOD
			left++
		} else {
			right--
		}
	}

	return result
}
