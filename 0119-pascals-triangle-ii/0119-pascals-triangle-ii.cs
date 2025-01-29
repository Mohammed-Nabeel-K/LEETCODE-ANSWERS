public class Solution {
    public IList<int> GetRow(int rowIndex) {
        IList<int> li = new List<int>(){1};
        for(int i=1;i<=rowIndex;i++){
            li.Add((int)((long)li[i - 1] * (rowIndex - i + 1) / i));
        }
        
        return li;
    }
}