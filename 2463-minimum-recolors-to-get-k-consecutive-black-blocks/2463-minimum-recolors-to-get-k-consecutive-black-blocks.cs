using System.Linq;
public class Solution {
    public int MinimumRecolors(string blocks, int k) {
        int count = k;
        for(int i = 0;i<blocks.Length-k+1;i++){
            string ss =blocks.Substring(i,k);
            if(ss.Distinct().SequenceEqual("B")){
                return 0;
            }else {
               int n = ss.Count(s => s == 'W');
                if(n<count) {count = n;}
            }

        }
        return count;
    }
}