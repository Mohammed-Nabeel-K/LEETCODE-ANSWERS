public class Solution {
    public string[] FindRestaurant(string[] list1, string[] list2) {
        Dictionary<string,int> dict = new Dictionary<string,int>();
        foreach(string i in list1){
            if(list2.Contains(i)){
                int idx = Array.IndexOf(list1,i)+ Array.IndexOf(list2,i);
                dict.Add(i,idx);
                
            }
        }
        int min = int.MaxValue;
        foreach(int value in dict.Values){
            if(min>value){
                min = value;
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