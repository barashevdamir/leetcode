public class Solution {
    public int ArrangeCoins(int n)
    {
        Int64 left = 0;
        Int64 right = n;
        while (left <= right)
        {
            Int64 mid = left + (right - left) / 2;
            Int64 sum = mid * (mid + 1) / 2;
            if (sum == n)
            {
                return (int)mid;
            }
            else if (sum < n)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return (int)right;
    }
}