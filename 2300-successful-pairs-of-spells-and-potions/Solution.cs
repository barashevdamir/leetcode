class Solution {
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success) {
        Array.Sort(potions);
        int[] result = new int[spells.Length];
        
        for (int i = 0; i < spells.Length; i++) {
            int left = 0;
            int right = potions.Length - 1;
            while (left <= right) {
                int mid = left + (right - left) / 2;
                long product = (long) spells[i] * potions[mid];
                if (product >= success) {
                    right = mid - 1;
                } else {
                    left = mid + 1;
                }
            }
            result[i] = potions.Length - left;
        }
        return result;
    }
}