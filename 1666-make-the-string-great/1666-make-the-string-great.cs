public class Solution {
    public string MakeGood(string s) {
        Stack<char> st = new Stack<char>();
        foreach(char c in s){
            if(st.Count>0 && (st.Peek() == char.ToLower(c) && char.IsUpper(c) || 
                                 st.Peek() == char.ToUpper(c) && char.IsLower(c))){
                st.Pop();
            }
            
            else{
                st.Push(c);
            }
        }
        StringBuilder ans = new StringBuilder();
        while(st.Count>0){
            ans.Insert(0,st.Pop());
        }
        return ans.ToString();
    }
}