package Leetcode

func hIndex(citations []int) int {
	left := 0
	right := len(citations) - 1
	for left <= right {
		mid := left + (right-left)/2
		if citations[mid] < len(citations)-mid {
			left = mid + 1
		} else {
			right = mid - 1
		}
	}
	return len(citations) - left
}
