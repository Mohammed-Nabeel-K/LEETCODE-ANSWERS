public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        bool[] ans = new bool[candies.Length];
        for(int i =0; i<candies.Length; i++){
            int sum = candies[i] + extraCandies;
            int big = candies.Max();
            if(sum >= big){
                ans[i] = true;
            }else{
                ans[i] = false;
            }
            
        }
        return ans;
    }
}