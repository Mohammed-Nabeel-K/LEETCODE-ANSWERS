public class Solution {
    public string[] FindRestaurant(string[] list1, string[] list2) {
        Dictionary<string,int> dict = new Dictionary<string,int>();
        int min = int.MaxValue;

        Dictionary<string, int> list2Index = new Dictionary<string, int>();
        for (int i = 0; i < list2.Length; i++) {
            list2Index[list2[i]] = i;
        }

        foreach(string i in list1){
            if(list2Index.ContainsKey(i)){
                int idx = Array.IndexOf(list1,i)+ list2Index[i];
                dict.Add(i,idx);
                if(min>idx){
                    min = idx;
                }
            }
        }
        
        List<string> arr = new List<string>();
        foreach(var item in dict){
            if(item.Value == min){
                arr.Add(item.Key);
            }
        }
        return arr.ToArray();
    }
}