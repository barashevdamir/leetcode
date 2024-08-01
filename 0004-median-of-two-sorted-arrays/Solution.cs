public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        if (nums1.Length > nums2.Length) {
            return FindMedianSortedArrays(nums2, nums1);
        }

        int m = nums1.Length;
        int n = nums2.Length;
        int imin = 0, imax = m, halfLen = (m + n + 1) / 2;
        while (imin <= imax) {
            int i = (imin + imax) / 2;
            int j = halfLen - i;
            if (i < m && nums1[i] < nums2[j-1]) {
                imin = i + 1;
            } else if (i > 0 && nums1[i-1] > nums2[j]) {
                imax = i - 1;
            } else {
                int max_of_left;
                if (i == 0) { max_of_left = nums2[j-1]; }
                else if (j == 0) { max_of_left = nums1[i-1]; }
                else { max_of_left = Math.Max(nums1[i-1], nums2[j-1]); }
                
                if ((m + n) % 2 == 1) {
                    return max_of_left;
                }

                int min_of_right;
                if (i == m) { min_of_right = nums2[j]; }
                else if (j == n) { min_of_right = nums1[i]; }
                else { min_of_right = Math.Min(nums1[i], nums2[j]); }

                return (max_of_left + min_of_right) / 2.0;
            }
        }

        return 0.0;
    }
}