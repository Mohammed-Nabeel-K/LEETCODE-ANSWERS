/**
 * @param {number[]} nums
 * @return {number}
 */
var missingNumber = function(nums) {
    let f;
    for( let i=0; i<nums.length+1; i++){
        let  k = nums.includes(i);
        if( k == false){
            f =  i;
        }
    }
  return f;  
};