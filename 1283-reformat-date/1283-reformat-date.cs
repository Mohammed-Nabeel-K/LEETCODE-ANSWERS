public class Solution {
    public string ReformatDate(string date) {
        string[] li = ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"];
        string[] arr = date.Split(" ");
        string day = arr[0].Substring(0,arr[0].Length-2);
        if (day.Length==1){
            day = "0"+day;
        }
        string month = (Array.IndexOf(li,arr[1])+1).ToString();
        if (month.Length==1){
            month = "0"+month;
        }
        string year = arr[2];
        string ans = year+"-"+month+"-"+day;
        return ans;
    }
}