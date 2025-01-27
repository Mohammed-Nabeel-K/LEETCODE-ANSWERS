public class Solution {
    public IList<int> Intersection(int[][] nums) {
        HashSet<int> res = new HashSet<int>(nums[0]);
        foreach(int[] i in nums.Skip(1)){
            res.IntersectWith(i);
        }
        return res.ToList();
    }
}