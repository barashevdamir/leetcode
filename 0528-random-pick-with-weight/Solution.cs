public class Solution {
    private int[] _weights;

    public Solution(int[] w)
    {
        _weights = new int[w.Length];
        var max = 0;
        for (var i = 0; i < w.Length; i++)
        {
            max += w[i];
            _weights[i] = max;
        }
    }
    
    public int PickIndex() {
        var random = new Random();
        var target = random.Next(0, _weights[_weights.Length - 1]);
        int left = 0, right = _weights.Length - 1;
        while (left < right)
        {
            int mid = left + (right - left) / 2;
            if (_weights[mid] <= target)
                left = mid + 1;
            else
                right = mid;
        }
        return left;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(w);
 * int param_1 = obj.PickIndex();
 */