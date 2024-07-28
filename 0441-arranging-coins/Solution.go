package Leetcode

func arrangeCoins(n int) int {
	left := 0
	right := n
	for left <= right {
		mid := (left + right) / 2
		sum := mid * (mid + 1) / 2
		if sum == n {
			return mid
		} else if sum < n {
			left = mid + 1
		} else {
			right = mid - 1
		}
	}
	return int(right)
}
