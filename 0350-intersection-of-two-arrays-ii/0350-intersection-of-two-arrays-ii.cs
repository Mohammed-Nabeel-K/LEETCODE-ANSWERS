public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        List<int> num2 = nums2.ToList();
        List<int> a = new List<int>();
        foreach(int i in nums1){
            if(num2.Contains(i)){
                a.Add(i);
                num2.Remove(i);
            }
        }
        return a.ToArray();
    }
}