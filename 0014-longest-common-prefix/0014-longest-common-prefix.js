/**
 * @param {string[]} strs
 * @return {string}
 */
var longestCommonPrefix = function(strs) {
    let stra = strs[0] ;
    let len = stra.length;
    let s = "";
    for (let i in strs){
        let h = strs[i];
        for ( let j = 0; j <=len; j++){
            if (stra.substring(0,j) == h.substring(0,j)){
                s = stra.substring(0,j);
            }
        }
        stra = s;
    }
    return stra;
};