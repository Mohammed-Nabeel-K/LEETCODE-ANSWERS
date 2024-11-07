public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        foreach(int i in nums){
            if(dict.ContainsKey(i)){
                dict[i] += 1;
            }else{
                dict[i] = 1;
            }
        }
        int max = 0;
        int val = 0;
        foreach(int j in dict.Keys){
            if(dict[j]>max){
                max = dict[j];
                val = j;
            }
        }
        return val;
    }
}