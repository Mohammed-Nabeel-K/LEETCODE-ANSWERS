/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    
    public int GuessNumber(int n) {
        int left = 0;
        int right = n;
        while(left <= right ){
            int num = left + (right-left) / 2;
            int gues = guess(num);
            if(gues == 0){
                return num;
            }else if(gues == -1){
                right = num-1;
            }else{
                left = num+1;
            }
            
        }
        return -1;
    }
}