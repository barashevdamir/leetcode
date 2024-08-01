package Leetcode

func findMedianSortedArrays(nums1 []int, nums2 []int) float64 {
	if len(nums1) > len(nums2) {
		return findMedianSortedArrays(nums2, nums1)
	}

	m, n := len(nums1), len(nums2)
	imin, imax, halfLen := 0, m, (m+n+1)/2
	for imin <= imax {
		i := (imin + imax) / 2
		j := halfLen - i
		if i < m && nums1[i] < nums2[j-1] {
			imin = i + 1
		} else if i > 0 && nums1[i-1] > nums2[j] {
			imax = i - 1
		} else {
			var max_of_left int
			if i == 0 {
				max_of_left = nums2[j-1]
			} else if j == 0 {
				max_of_left = nums1[i-1]
			} else {
				max_of_left = max(nums1[i-1], nums2[j-1])
			}
			if (m+n)%2 == 1 {
				return float64(max_of_left)
			}
			var min_of_right int
			if i == m {
				min_of_right = nums2[j]
			} else if j == n {
				min_of_right = nums1[i]
			} else {
				min_of_right = min(nums1[i], nums2[j])
			}
			return float64(max_of_left+min_of_right) / 2.0
		}
	}

	return 0.0
}
