public class Solution {
    public int NumOfStrings(string[] patterns, string word) {
        int c = 0;
        foreach(string i in patterns){
            if (word.Contains(i)){
                c++;
            }
        }
        return c;
    }
}