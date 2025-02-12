public class Solution {
    public int LargestAltitude(int[] gain) {
        int alt = 0;
        List<int> altitudes = new List<int>();
        foreach(int i in gain){
            altitudes.Add(alt);
            alt+=i;
        }
         altitudes.Add(alt);
        return altitudes.Max();
    }
}