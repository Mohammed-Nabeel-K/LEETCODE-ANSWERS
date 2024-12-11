public class Solution {
    public int ScoreOfString(string s) {
        int val = 0;
        char k = s[0];
        int prev=(int)k;
        foreach(char i in s){
            
            val+= Math.Abs(prev-(int)i);
            prev = (int)i;
        
        }
        return val;
    }
}