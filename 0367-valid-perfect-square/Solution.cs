public class Solution {
    public bool IsPerfectSquare(int num)
    {
        Int64  left = 0;
        Int64  right = num;
        while (left <= right)
        {
            Int64  mid = left + (right - left) / 2;

            if (mid * mid == num)
            {
                return true;
            }
            else if (mid * mid > num)
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }
        return false;
    }
}