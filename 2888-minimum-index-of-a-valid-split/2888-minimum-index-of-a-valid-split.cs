public class Solution {
    public int MinimumIndex(IList<int> nums) {
         int val = 0;
        int count = nums.Count / 2;
        Dictionary<int, int> dict = new Dictionary<int, int>();
        
        foreach (int num in nums) {
            if (dict.ContainsKey(num)) {
                dict[num] += 1;
            } else {
                dict.Add(num, 1);
            }
        }
        
        foreach (var kvp in dict) {
            if (kvp.Value > count) {
                val = kvp.Key;
                break;
            }
        }
        
        int l = 0, r = dict[val];
        for (int i = 0; i < nums.Count; i++) {
            if (nums[i] == val) {
                l++;
                r--;
            }
            if (l * 2 > (i + 1) && r * 2 > (nums.Count - i - 1)) {
                return i;
            }
        }
        return -1;
    }
}