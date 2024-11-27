public class Solution {
    public string ReverseWords(string s) {
        s = s.Trim();
        string[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        Array.Reverse(words);
        
        string reversedSentence = string.Join(" ", words);

        return reversedSentence;
    }
}