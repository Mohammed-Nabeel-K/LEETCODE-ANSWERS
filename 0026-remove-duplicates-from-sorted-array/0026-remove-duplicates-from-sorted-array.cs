public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int[] result = nums.Distinct().ToArray();
        for(int i=0; i<result.Length; i++){
            nums[i] = result[i];
        }
        return result.Length;
    }
}