public class Solution {
    public bool IsPalindrome(int x) {
        int rev = 0;
        int org = x;
        while(x > 0){
            int d = x %10;
            rev = rev * 10 + d;
            x /= 10;
        }
        if ( org == rev ){
            return true;
        }
        return false;
    }
}