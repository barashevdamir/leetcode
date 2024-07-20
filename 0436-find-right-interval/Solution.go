package Leetcode

import "sort"

func findRightInterval(intervals [][]int) []int {
	if len(intervals) == 0 {
		return []int{}
	}
	starts := make([][]int, len(intervals))
	for i := 0; i < len(intervals); i++ {
		starts[i] = []int{intervals[i][0], i}
	}
	sort.Slice(starts, func(a, b int) bool {
		return starts[a][0] < starts[b][0]
	})

	output := make([]int, len(intervals))

	for index := range intervals {
		end := intervals[index][1]
		left := 0
		right := len(intervals) - 1

		for left <= right {
			mid := left + (right-left)/2
			if starts[mid][0] >= end {
				right = mid - 1
			} else {
				left = mid + 1
			}
		}
		output[index] = -1
		if left != len(intervals) {
			output[index] = starts[left][1]
		}
	}
	return output
}
