public class Solution {
    public bool IsAnagram(string s, string t) {
        string arrs = String.Join("", s.ToCharArray().OrderBy(c => c));
        string arrt = String.Join("", t.ToCharArray().OrderBy(c => c));
        return arrs == arrt;

    }
}