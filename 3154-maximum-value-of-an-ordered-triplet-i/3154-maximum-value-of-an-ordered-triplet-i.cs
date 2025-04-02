public class Solution {
    public long MaximumTripletValue(int[] nums) {
        long ans = 0;
        for(int i=0;i<nums.Length-2;i++){
            for(int j=i+1;j<nums.Length-1;j++){
                for(int k=j+1;k<nums.Length;k++){
                    long a = (long)(nums[i] - nums[j]) * (long)nums[k];
                    if(a>ans){
                        ans = a;
                    }
                }
            }
        }
        return ans;
    }
}