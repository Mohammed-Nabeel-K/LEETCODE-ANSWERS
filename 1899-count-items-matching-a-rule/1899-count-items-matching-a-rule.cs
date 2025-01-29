public class Solution {
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue) {
        int count = 0;
        foreach(IList<string> item in items){
            if(ruleKey == "type" && item[0] == ruleValue ){
                count++;
            }
            if(ruleKey == "color" && item[1] == ruleValue ){
                count++;
            }
            if(ruleKey == "name" && item[2] == ruleValue ){
                count++;
            }
        }
        return count;
    }
}