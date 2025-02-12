public class Solution {
    public int LargestAltitude(int[] gain) {
        int alt = 0;
        int max = 0;
        foreach(int i in gain){
            alt+=i;
            if(alt>max){
                max = alt;
            }
        }
        return max;
    }
}