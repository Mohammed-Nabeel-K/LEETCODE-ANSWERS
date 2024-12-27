/**
 * @param {number[]} values
 * @return {number}
 */
var maxScoreSightseeingPair = function(values) {
    let maxScope = 0;
    let maxleft = values[0];
    for(let i = 1; i<values.length; i++){
        maxScope = Math.max(maxScope,maxleft+values[i]-i)
        maxleft = Math.max(maxleft, values[i]+i)
    } 
    return maxScope;
};