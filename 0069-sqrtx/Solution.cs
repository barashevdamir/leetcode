public class Solution {
    public int MySqrt(int x)
    {
        Int64 left = 0;
        Int64 right = x;
        while (left <= right)
        {
            Int64 mid = left + (right - left) / 2;
            if (mid * mid == x)
            {
                return (int)mid;
            }
            else if (mid * mid < x)
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