public class Solution {
    public string ClearDigits(string s) {
        List<char> charList = s.ToList();
        for (int i = 0; i<charList.Count; i++){
            if(char.IsDigit(charList[i])){
                charList.RemoveAt(i);
                charList.RemoveAt(i-1);
                i--;
                i--;
            }
        }
        string ss = string.Join("",charList);
        return ss;
    }
}