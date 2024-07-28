public class Solution {
    public int HIndex(int[] citations)
    {
        int left = 0;
        int right = citations.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (citations[mid] < citations.Length - mid)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return citations.Length - left;
    }
}