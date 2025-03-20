public class Solution {
    public int MinOperations(int[] nums) {
        int count = 0;
        int n = nums.Length;

        for (int i = 0; i <= n - 3; i++) {
            if (nums[i] == 0) {
                nums[i] = 1;
                nums[i + 1] ^= 1;
                nums[i + 2] ^= 1;
                count++;
            }
        }
        foreach (int num in nums) {
            if (num == 0) return -1;
        }

        return count;
    }
}
