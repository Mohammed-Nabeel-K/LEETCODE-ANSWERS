public class Solution {
    public bool IsPalindrome(string s) {
        string result = new string(s.Where(c => Char.IsLetterOrDigit(c)).Select(c => Char.ToLower(c)) .ToArray());

        string ss = new string(result.Reverse().ToArray());
        return ss == result;
    }
}