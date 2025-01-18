public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        Dictionary<int, int> numDict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            if (numDict.ContainsKey(nums[i])) {
                if (i - numDict[nums[i]] <= k) {
                    return true;
                }
            }
            numDict[nums[i]] = i;
        }
        return false;
    }
}