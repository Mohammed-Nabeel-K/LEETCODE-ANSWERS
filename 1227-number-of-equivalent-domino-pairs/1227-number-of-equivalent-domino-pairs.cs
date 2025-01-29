public class Solution {
    public int NumEquivDominoPairs(int[][] dominoes) {
        int count = 0;
        Dictionary<int,int> dict = new Dictionary<int,int>();

        foreach(int[] domino in dominoes){
            int key = domino[0] < domino[1] 
                ? domino[0] * 10 + domino[1] 
                : domino[1] * 10 + domino[0];

            if(dict.ContainsKey(key)){
                count+=dict[key];
                dict[key]++;

            }else{
                dict[key] = 1;
            }
        }

        
        return count;
    }
}