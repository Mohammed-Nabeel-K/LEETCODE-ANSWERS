public class Solution {
    public int RemoveElement(int[] nums, int val) {
     int[] result = nums.Where(x => x != val).ToArray();
     for(int i=0;i<result.Length;i++){
        nums[i] = result[i];
     }
     return result.Length;
    }
}