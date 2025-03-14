public class Solution {
    public int MaximumCandies(int[] candies, long k) {
        
        long totel = candies.Sum(c => (long)c);
        int left = 1;
        int right = (int)Math.Min(totel/k , candies.Max());
        if(totel>=k){
          
         while(left<=right){
            int mid = (left + (right - left)/2);
            long count = 0;
            foreach(int i in candies){
                count += i/mid;
                if (count>=k){
                    break;
                }
            }

            if(count>=k){
                left = mid + 1;
            }else{
                right = mid - 1;
            }
        }
        
        }
       return right;
        
    }
}