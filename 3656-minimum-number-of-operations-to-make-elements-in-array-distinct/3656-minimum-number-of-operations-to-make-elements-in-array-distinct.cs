public class Solution {
    public int MinimumOperations(int[] nums) {
        int n = nums.Length;
        int start = 0;
        int ops = 0;

        while (start < n) {
            var seen = new HashSet<int>();
            bool hasDuplicate = false;
            for (int i = start; i < n; i++) {
                if (!seen.Add(nums[i])) {
                    hasDuplicate = true;
                    break;
                }
            }

            if (!hasDuplicate) break;
            start += 3;
            ops++;
        }

        return ops;
    }
}