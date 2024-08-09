public class Solution {
    private const int MOD = 1_000_000_007;

    public int NumSubseq(int[] nums, int target) {
        Array.Sort(nums);
        int result = 0;
        int left = 0;
        int right = nums.Length - 1;
        int[] pow = new int[nums.Length];
        pow[0] = 1;

        for (int i = 1; i < nums.Length; i++) {
            pow[i] = pow[i - 1] * 2 % MOD;
        }
        
        while (left <= right) {
            if (nums[left] + nums[right] <= target) {
                result = (result + pow[right - left]) % MOD;
                left++;
            } else {
                right--;
            }
        }
        
        return result;
    }
}