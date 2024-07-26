/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        int left = 0, right = n;
        while (left < right) {
            int mid = left + (right - left) / 2;
            bool isBadVersion = IsBadVersion(mid);
            if (isBadVersion) {
                right = mid;
            } else {
                left = mid + 1;
            }
        }
        return left;
    }
}