public class Solution {
    public string TriangleType(int[] nums) {
        int a = nums[0];
        int b = nums[1];
        int c = nums[2];
        if(a == b && b == c){
            return "equilateral";
        }
        
        if((a+b) > c && (a+c) > b && (b+c) > a){
            if(a == b || b == c || a == c){
            return "isosceles";
        }
            return "scalene";
        }
        return "none";
    }
}