/**
 * @param {string} s
 * @return {number}
 */
var scoreOfString = function(s) {
    let arr= [];
    for(i = 0; i<s.length-1;i++){
        let a = s.charCodeAt(i);
        let b = s.charCodeAt(i+1);
        let c = a-b;
        arr.push(Math.abs(c))
    }
    return arr.reduce((ac,val)=>ac+val);
};