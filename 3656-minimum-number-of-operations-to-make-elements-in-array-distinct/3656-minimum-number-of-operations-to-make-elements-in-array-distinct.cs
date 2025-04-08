public class Solution {
    public int MinimumOperations(int[] nums) {
        var numsList = new List<int>(nums);
        int count = 0;
        while (numsList.Count > 0) {
            if (numsList.Count == numsList.Distinct().Count()) {
                break;
            }
            int removeCount = Math.Min(3, numsList.Count);
            numsList.RemoveRange(0, removeCount);
            count++;
        }

       
        return count;
    }
}