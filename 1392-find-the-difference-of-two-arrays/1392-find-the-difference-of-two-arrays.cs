public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        HashSet<int> set1 = nums1.ToHashSet();
        HashSet<int> set2 = nums2.ToHashSet();
        IList<int> a = new List<int>();
        IList<int> b = new List<int>();
        foreach (var num in set1) {
            if (!set2.Contains(num)) {
                a.Add(num);
            }
        }
        foreach (var num in set2) {
            if (!set1.Contains(num)) {
                b.Add(num);
            }
        }
        return new List<IList<int>> { a, b };
    }
}