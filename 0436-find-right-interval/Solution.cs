public class Solution
{
    public int[] FindRightInterval(int[][] intervals)
    {
        if (intervals.Length == 0) return new int[] { -1 };
        
        int[][] starts = new int[intervals.Length][];
        for (int i = 0; i < intervals.Length; i++)
        {
            starts[i] = new int[] { intervals[i][0], i };
        }
        
        Array.Sort(starts, (a, b) => a[0].CompareTo(b[0]));

        var output = new int[intervals.Length];
        
        for (var index = 0; index < intervals.Length; index++)
        {
            int end = intervals[index][1];
            int left = 0;
            int right = intervals.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (starts[mid][0] < end)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            output[index] = left == intervals.Length ? -1 : starts[left][1];
        }

        return output;
    }
}