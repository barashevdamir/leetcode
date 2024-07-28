public class Solution {
    public int FindKthPositive(int[] arr, int k) {
        Int64 left = 0;
        Int64 right = arr.Length;
        while (left < right) {
            Int64 mid = left + (right - left) / 2;
            if (arr[mid] - mid - 1 < k) {
                left = mid + 1;
            } else {
                right = mid;
            }
        }
        return (int)left + k;
    }
}