package Leetcode

func mySqrt(x int) int {
	left := 0
	right := x
	for left <= right {
		mid := left + (right-left)/2
		if mid*mid > x {
			right = mid - 1
		} else if mid*mid < x {
			left = mid + 1
		} else {
			return int(mid)
		}
	}
	return int(right)

}
