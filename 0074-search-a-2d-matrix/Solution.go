package Leetcode

func searchMatrix(matrix [][]int, target int) bool {
	m := len(matrix)
	n := len(matrix[0])
	left := 0
	right := m*n - 1
	for left <= right {
		mid := left + (right-left)/2
		midVal := matrix[mid/n][mid%n]
		if midVal == target {
			return true
		} else if midVal > target {
			right = mid - 1
		} else {
			left = mid + 1
		}
	}
	return false
}
