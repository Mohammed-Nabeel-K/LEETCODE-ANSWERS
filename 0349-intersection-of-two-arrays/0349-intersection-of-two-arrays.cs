public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        HashSet<int> set1 = nums1.ToHashSet();
        HashSet<int> set2 = nums2.ToHashSet();
        List<int> a = new List<int>();
        foreach(int i in set1){
            if(set2.Contains(i)){
                a.Add(i);
            }
        }
        return a.ToArray();
    }
}